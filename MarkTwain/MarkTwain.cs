using KeePassLib;
using KeePassLib.Cryptography;
using KeePassLib.Cryptography.PasswordGenerator;
using KeePassLib.Security;
using MarkTwain.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// per David, here are more requirements: https://www.xkpasswd.net/

namespace MarkTwain
{
    public sealed class MarkTwain : CustomPwGenerator
    {
		private readonly List<string> _passwordList;
		public MarkTwain()
        {
			_passwordList = Resources.WordList.Split(new string[] { "\r\n","\n" },StringSplitOptions.None).ToList();
        }		
       
        private static readonly PwUuid m_uuid = new PwUuid(new byte[] {
			0x6A, 0x5E, 0x04, 0xE1, 0xAD, 0xB5, 0x61, 0x41,
            0x92, 0x9E, 0xF1, 0x68, 0x80, 0x79, 0xC3, 0xD1 });
		public override PwUuid Uuid
		{
			get { return m_uuid; }
		}

        public override string Name => "MarkTwain";

		public string GetWord()
        {
			Random c = new Random();
			var rc = c.Next(0,_passwordList.Count - 1);
			return _passwordList[rc];
        }

        public override ProtectedString Generate(PwProfile prf, CryptoRandomStream crsRandomSource)
        {
   //         if(prf == null) { Debug.Assert(false); }
			//else
			//{
			//	Debug.Assert(prf.CustomAlgorithmUuid == Convert.ToBase64String(
			//		m_uuid.UuidBytes, Base64FormattingOptions.None));
			//}

			const int minLength = 14;
			int maxWords = _passwordList.Count();
			string pw;
            do
            {
				var sb = new StringBuilder();
                // find indices for two words in the list				
				ulong u1 = 0;
				ulong u2 = 0;
                while (u1 == u2)
                {
					u1 = crsRandomSource.GetRandomUInt64();
					u2 = crsRandomSource.GetRandomUInt64();
					u1 %= (ulong)maxWords;
					u2 %= (ulong)maxWords;
                }
				
				// get the two words
				var word1 = _passwordList[(int)u1];
				var word2 = _passwordList[(int)u2];
				if(crsRandomSource.GetRandomUInt64() < ulong.MaxValue / 2)
                {
					word1 = word1.ToUpperInvariant();
                }
                else
                {
					word2 = word2.ToUpperInvariant();
                }

				// get indices for special characters
				ulong sc1 = 0;
				ulong sc2 = 0;
                while (sc1 == sc2)
                {
					sc1 = crsRandomSource.GetRandomUInt64();
					sc2 = crsRandomSource.GetRandomUInt64();
					sc1 %= (ulong)PwCharSet.PrintableAsciiSpecial.Length;
					sc2 %= (ulong)PwCharSet.PrintableAsciiSpecial.Length;
                }

				var specialCharacter1 = PwCharSet.PrintableAsciiSpecial[(int)sc1];
				var specialCharacter2 = PwCharSet.PrintableAsciiSpecial[(int)sc2];

				// get indices for digits
				int number1 = 0;
				int number2 = 0;
				while(number1 == number2)
                {
					var rb1 = crsRandomSource.GetRandomBytes(2);
					var rb2 = crsRandomSource.GetRandomBytes(2);
					number1 = BitConverter.ToUInt16(rb1,0)%99;
					number2 = BitConverter.ToUInt16(rb2,0)%99;
                }
				// create the password
				sb.Append(specialCharacter1.ToString() + 
						  specialCharacter1.ToString() +
						  number1.ToString() +
						  specialCharacter2.ToString() +
						  word1 +
						  specialCharacter2.ToString() +
						  word2 +
						  specialCharacter2.ToString() +
						  number2.ToString() +
						  specialCharacter1.ToString() +
						  specialCharacter1.ToString());
				pw = sb.ToString();
            }while(pw.Length < minLength);

			return new ProtectedString(false,pw);
        }
    }
}


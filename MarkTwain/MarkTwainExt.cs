using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeePass.Plugins;
using MarkTwain.Properties;

namespace MarkTwain
{
    public class MarkTwainExt : Plugin
    {
        private IPluginHost m_host = null;
        private MarkTwain m_gen = null;

		public override bool Initialize(IPluginHost host)
		{
            Terminate();
			if(host == null) return false;
			m_host = host;            
            m_gen = new MarkTwain();
            m_host.PwGeneratorPool.Add(m_gen);
			return true;
		}

        public override void Terminate()
        {
            if(m_host == null) return;

			m_host.PwGeneratorPool.Remove(m_gen.Uuid);

			m_gen = null;
			m_host = null;
        }
    }
}

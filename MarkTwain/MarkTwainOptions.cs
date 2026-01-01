namespace MarkTwain
{
    internal class MarkTwainOptions
    {
        internal int MinimumPasswordLength { get; set; }
        internal int NumberOfWords { get; set; }

        internal int MinimumWordLength { get; set; }
        internal int MaximumWordLength { get; set; }

        internal MarkTwainOptions(MarkTwainOptions opts)
        {
            MinimumPasswordLength = opts.MinimumPasswordLength;
            NumberOfWords = opts.NumberOfWords;
            MinimumWordLength = opts.MinimumWordLength;
            MaximumWordLength = opts.MaximumWordLength;
        }

        internal MarkTwainOptions()
        {
            MinimumPasswordLength = 8;
            NumberOfWords = 2;
            MinimumWordLength = 3;
            MaximumWordLength = 10;
        }

        internal string Serialize()
        {
            return $"{MinimumPasswordLength}|{NumberOfWords}|{MinimumWordLength}|{MaximumWordLength}";
        }
        
        internal static MarkTwainOptions Deserialize(string data)
        {
            var options = new MarkTwainOptions();
            
            if (string.IsNullOrEmpty(data))
                return options;
            
            try
            {
                string[] parts = data.Split('|');
                if (parts.Length >= 3)
                {
                    options.MinimumPasswordLength = int.Parse(parts[0]);
                    options.NumberOfWords = int.Parse(parts[1]);
                    options.MinimumWordLength = int.Parse(parts[2]);
                    options.MaximumWordLength = int.Parse(parts[3]);                   
                }
            }
            catch
            {
                // Return defaults on parse error
            }
            
            return options;
        }
    }
}

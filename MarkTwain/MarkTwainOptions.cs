namespace MarkTwain
{
    internal class MarkTwainOptions
    {
        internal int MinimumPasswordLength { get; set; }
        internal int MaximumPasswordLength { get; set; }
        internal int NumberOfWords { get; set; }

        internal int MinimumWordLength { get; set; }
        internal int MaximumWordLength { get; set; }

        internal MarkTwainOptions(MarkTwainOptions opts)
        {
            MinimumPasswordLength = opts.MinimumPasswordLength;
            MaximumPasswordLength = opts.MaximumPasswordLength;
            NumberOfWords = opts.NumberOfWords;
            MinimumWordLength = opts.MinimumWordLength;
            MaximumWordLength = opts.MaximumWordLength;
        }

        internal MarkTwainOptions()
        {
            MinimumPasswordLength = 11;
            MaximumPasswordLength = 1000;
            NumberOfWords = 2;
            MinimumWordLength = 3;
            MaximumWordLength = 10;
        }

        internal string Serialize()
        {
            return $"{MinimumPasswordLength}|{MaximumPasswordLength}|{NumberOfWords}|{MinimumWordLength}|{MaximumWordLength}";
        }
        
        internal static MarkTwainOptions Deserialize(string data)
        {
            var options = new MarkTwainOptions();
            
            if (string.IsNullOrEmpty(data))
                return options;
            
            try
            {
                string[] parts = data.Split('|');
                if (parts.Length == 5)
                {
                    options.MinimumPasswordLength = int.Parse(parts[0]);
                    options.MaximumPasswordLength = int.Parse(parts[1]);
                    options.NumberOfWords = int.Parse(parts[2]);
                    options.MinimumWordLength = int.Parse(parts[3]);
                    options.MaximumWordLength = int.Parse(parts[4]);                   
                }
                if (parts.Length == 4) // backwards compatibility
                {
                    options.MinimumPasswordLength = int.Parse(parts[0]);
                    options.MaximumPasswordLength = 1000;
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

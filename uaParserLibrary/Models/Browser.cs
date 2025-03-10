﻿namespace uaParserLibrary.Models
{
    public sealed class Browser
    {
        public string Name { get; set; }

        public string Major { get; set; }

        public string Version { get; set; }

        public override string ToString() => $"{"Browser",-7}: {Name} {Version}";

        public Browser Empty
        {
            get
            {
                Name = "Other";
                Major = string.Empty;
                Version = string.Empty;
                return this;
            }
        }

       
 
    }
}
using System;
using System.Collections.Generic;

namespace Plugin.Configuration
{
    public class EmbyStatConfiguration
    {
        public string EmbyStatUrl { get; set; }
        public List<string> LibraryTypesToScan { get; set; }
    }
}

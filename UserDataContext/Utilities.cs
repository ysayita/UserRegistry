using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace UserDataContext
{
    static class Utilities
    {
        public static string ReadConfig(string Key) => ConfigurationManager.AppSettings[Key]?.Trim();        
    }
}

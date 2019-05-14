using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public sealed class AppOptions
    {
        private static readonly object padlock = new object();

        private static AppOptions _instance;

        public static AppOptions Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new AppOptions();
                        }
                    }
                }
                return _instance;
            }
        }

        private AppOptions()
        {
        }

        public DateTime TimeZone { get; set; }

        public string ApplicationOwner { get; set; }

        public bool InCloud { get; set; }

        public bool HasOwner { get; set; }
    }
}

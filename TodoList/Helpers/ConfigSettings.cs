using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Helpers.Interfaces;

namespace TodoList.Helpers
{
    public class ConfigSettings : IConfigSettings
    {
        public ConfigSettings()
        {
            // the best pratice is to read the token from appSettings.json

            AccessToken = "8FFDF5F4-8CD6-46D0-A882-8D80AAD9B0C3";
        }
        public string AccessToken { get; private set; }
    }
}


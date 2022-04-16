using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum GreetingOptions
    {
        Hey_You,        
        Good_Sir,
        My_Lady,
        Lord
    }

    /// <summary>
    /// This extension takes the enum value with underscores and returns a human
    /// friendly string with spaces instead.
    /// </summary>
    static class GreetingOptionsExtensions
    {
        public static string DisplayText(this GreetingOptions e)
        {
            return e.ToString().Replace('_', ' ');
        }
    }
}

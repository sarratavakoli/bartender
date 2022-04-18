using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Enum of greeting options used by Actions.Greet to generate dynamic menu and greeting
    /// selection from user. Adventurer favored/hated greeting preferences stored in Adventurer.Greeting
    /// and Adventurer.HatedGreeting.
    /// </summary>
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

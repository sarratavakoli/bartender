using System.ComponentModel;

namespace Library
{
    public enum GreetingOptions
    {
        [Description("Hey You")]
        HeyYou,
        [Description("Good Sir")]
        GoodSir,
        [Description("Ma'am")]
        Maam,
        [Description("Hey You")]
        Lord
    }
}

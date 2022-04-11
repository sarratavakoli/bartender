namespace Library
{
    public class Formatting
    {
        public static void DarkText()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public static void BrightText()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public static void BartenderASCII()
        {
            BrightText();
            Console.Write(@"
                           (     )
                            (   )
                            (  )
                           (  )
                            ) )
                           ( )                   /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
                I_I|  I__I_____[]_|_[]_____I
                I_II  I__I_____[]_|_[]_____I
                I II__I  I     XXXXXXX     I
            ~~~~~~'  '~~~~~~~~~~~~~~~~~~~~~~~~
");
            DarkText();
            Console.Write(@"
-------------------------------------------------------------");
            BrightText();
            Console.Write(@"

            B   A   R   T   E   N   D   E    R ");
            DarkText();
            Console.WriteLine(@"
 
-------------------------------------------------------------
            ");
        }
    }
}

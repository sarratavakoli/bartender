namespace Library
{
    public class Formatting
    {
        //Console.SetWindowSize(w, h) to make the window a static size and then
        //Console.SetCursorPosition(x, y) to set where the next console writeline starts
        //and some for loops along with string.ToString.Split to turn strings into arrays
        //and then for loops to move the Y coordinate down for each line
        //split on '\n' to make an array out of my ToString method for displaying stuff

        /// <summary>
        /// Change text to a standard dark color
        /// </summary>
        public static void DarkText()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        
        /// <summary>
        /// Change text to a standard light color
        /// </summary>
        public static void BrightText()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        /// <summary>
        /// Clear the screen, Display game splash page and game title at the top of the screen
        /// </summary>
        public static void BartenderASCII()
        {
            Console.Clear();
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

            B   A   R   T   E   N   D   E   R ");
            DarkText();
            Console.WriteLine(@"
 
-------------------------------------------------------------");
        }

        /// <summary>
        /// Just a method used as needed to select colors I may want to use to change the program.
        /// </summary>
        public static void ColorTest()
        {
            #region color demo
            // Demonstrate all colors and backgrounds.
            Type type = typeof(ConsoleColor);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }
            #endregion
        }
    }
}

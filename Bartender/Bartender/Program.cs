using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region title
            Console.Title = "Bartender ~ Can you save them?";

            BartenderASCII();
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey(true);
            #endregion

            #region intro
            Console.WriteLine(
                "\nOnce upon a time there was a magical kingdom. A Queen ruled over the\n" +
                "lands, but dark forces threatened the safety of her citizens.\n" +
                "The world would never see peace without a valiant hero to pave the way...\n");
            Console.ReadKey(true);
            Console.WriteLine(
                "I'm sorry, did you think that was YOU? You are definitely not out there\n" +
                "trying to save the world.  You would much rather stay home with a cold\n" +
                "brew and live to see another day. Which is exactly where our story begins...\n");
            Console.ReadKey(true);
            #endregion



            #region components to use later
            /* This generates a random line of text as defined in
             * the method FlavorText's string array.
             * Console.WriteLine(FlavorText());
             */
            #endregion
        }

        static void BartenderASCII()
        {
            Console.WriteLine(@"
                           (     )
                            (   )
                            (  )
                           (  )
                            ) )
                           ( )                  /\
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

-------------------------------------------------------------

            B   A   R   T   E   N   D   E    R 
 
-------------------------------------------------------------
            ");
        }

        private static string FlavorText()
        {
            /* this method stores an array of text options that can be selected at random.
             * will use this format to create similar methods as needed, housing 
             * different type of flavor text.
             */
            string[] flavorTexts =
            {
                "text1",
                "text2",
                "text3",
                "text4",
                "text5",
                "text6"
            };
            Random rand = new Random();
            int indexNbr = rand.Next(flavorTexts.Length);
            return flavorTexts[indexNbr];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region color demo
            //// Demonstrate all colors and backgrounds.
            //Type type = typeof(ConsoleColor);
            //Console.ForegroundColor = ConsoleColor.White;
            //foreach (var name in Enum.GetNames(type))
            //{
            //    Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
            //    Console.WriteLine(name);
            //}
            //Console.BackgroundColor = ConsoleColor.Black;
            //foreach (var name in Enum.GetNames(type))
            //{
            //    Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
            //    Console.WriteLine(name);
            //}
            #endregion

            #region title
            Console.Title = "Bartender ~ Can you save them?";

            Formatting.BartenderASCII();
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey(true);
            #endregion

            #region characters initialized
            
            //the player's Character will be initialized with 100 det
            Character player = new Character();
            
            //adventurers will have varying det
            Character bilbo = new Character("Bilbo", "Baggins",
                "One of a race of creatures about half the size of humans,\n" +
                "beardless and with hairy feet. He has a pipe at the ready.\n" +
                "He doesn't really appear to be an adventurer at all.", 10, 7, 10, 1,
                DrinkOptions.Tea, DrinkOptions.Cider);
            Character harry = new Character("Harry", "Potter", 
                "Infamous among wizarding folk, this young man has a peculiar\n" +
                "lightning bolt mark on his forehead. He looks like your\n" +
                "average nerdy student in a school uniform, but he carries\n" +
                "a wand and an owl appears to be waiting for him outside.", 15, 1, 10, 1,
                DrinkOptions.Cider, DrinkOptions.Tea);
            Character tyrion = new Character("Tyrion", "Lannister", 
                "A frequent patron of many drinking establishments, he\n" +
                "makes up for his lack of height with wit, charm, and alcohol.\n" +
                "tolerance. Just your kind of guy.\n", 50, 10, 8, 8,
                DrinkOptions.Wine, DrinkOptions.Beer);
            Character xena = new Character("Xena", ", Warrior Princess",
                "A powerful warrior in leathers with a chakram and a sword,\n" +
                "she seeks to fight for the powers of good to make up for\n" +
                "her dark past. One of your most intimidating patrons.", 60, 1, 3, 3,
                DrinkOptions.Mead, DrinkOptions.Beer);
            Character inigo = new Character("Inigo", "Montoya",
                "A determined young man on a mission to avenge the death\n" +
                "of his father. He carries adistinguished rapier of the\n" +
                "17th century style. He is a little over the top, but\n" +
                "dedicated, you'll give him that.", 70, 1, 1, 4,
                DrinkOptions.Beer, DrinkOptions.Cider);
            Character geralt = new Character("Geralt", "of Rivia",
                "Known as a 'Witcher', Geralt is a magically enhanced\n" +
                "monster-hunter. This menacing, grumpy, silent adventurer\n" +
                "is known for his scraggly white hair, eyes that \n" +
                "sometimes glow orange with power, and signature grunt\n" +
                "you may receive in lieu of any other response. He is \n" +
                "surprisingly kind and a big hit with the ladies.", 40, 8, 10, 8,
                DrinkOptions.Beer, DrinkOptions.Mead);
            
            //list to hold all adventurers
            List<Character> characters = new List<Character>() {bilbo, harry, tyrion, xena, inigo, geralt};
            #endregion

            #region intro
            Console.WriteLine(
                "\nOnce upon a time there was a magical kingdom. A Queen ruled\n" +
                "over the lands, but dark forces threatened the safety of her\n" +
                "citizens. The world would never see peace without a valiant\n" +
                "hero to pave the way...\n");
            Console.ReadKey(true);
            Console.WriteLine(
                "I'm sorry, did you think that was YOU? You are definitely\n" +
                "not out there trying to save the world.  You would much\n" +
                "rather stay home with a cold brew and live to see another\n" +
                "day. Which is exactly where our story begins...\n");
            Console.ReadKey(true);
            #endregion

            #region get character name

            Console.WriteLine("YOU are the tavern's trusty bartender.\n");
            Formatting.BrightText();
            Console.WriteLine("So what is your full name?");
            Formatting.DarkText();
            ConsoleKey confirmName = ConsoleKey.N;

            do
            {
                Console.WriteLine();

                //gets full name from user and sets first and last name
                string s = Console.ReadLine();
                string[] subs = s.Split(' ');
                int n = 0;
                foreach (string sub in subs)
                {
                    if (n == 0)
                    {
                        player.FirstName = subs[0];
                    }
                    else if (n == 1)
                    {
                        player.LastName = " " + subs[1];
                    }
                    n++;
                }

                Console.WriteLine($"\n{player.FirstName}{player.LastName}... I see, aren't you an odd one.\n");
                Formatting.BrightText();
                Console.WriteLine("Did I get your full name right? (Y/N)");
                Formatting.DarkText();

                confirmName = Console.ReadKey(true).Key;
                switch (confirmName)
                {
                    case ConsoleKey.N:
                        Formatting.BrightText();
                        Console.WriteLine("\nAlright, let's try that again. What is your full name?");
                        Formatting.DarkText();
                        break;
                    case ConsoleKey.Y:
                        Console.WriteLine("\nExcellent. Nice to meet you.");
                        break;
                    default:
                        Console.WriteLine("\nWhat was that? I don't understand. Let's try that again.\n");
                        Formatting.BrightText();
                        Console.WriteLine("What is your full name?");
                        Formatting.DarkText();
                        break;
                }
            } while (confirmName != ConsoleKey.Y);

            //TODO: maybe force capitalization of first letter, lowercase other letters
            #endregion

            #region main loop 

            //exit bool is used for main game loop
            //game continues while exit is false
            bool exit = false;
            int characterIndex = 0;

            do //main game loop
            {
                Console.WriteLine($"Alright, bartender {player.FirstName}.");
                Console.WriteLine("It's time to get to work. Someone is waiting for you.\n");
                Console.WriteLine(characters[characterIndex].Description);
                Console.ReadKey(true);

                #region menu loop
                //menu loop continues while repeatMenu = true;
                bool repeatMenu = true;
                do
                {
                    //Introduce the current character we are interacting with
                    //present menu options
                    Formatting.BrightText();
                    Console.WriteLine("\nWhat will you do?");
                    Console.WriteLine("1) Offer them a drink\n" +
                        "2) Ask about their adventure\n" +
                        "3) Charm them\n" +
                        "4) Review what you know about them\n" +
                        "5) Check your progress\n" +
                        "6) Exit game\n");
                    Formatting.DarkText();

                    //get user selection as console key
                    ConsoleKey menuSelection = Console.ReadKey(true).Key;

                    //execute corresponding actions depending on selection
                    switch (menuSelection)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.Oem1:
                            //TODO: Offer them a drink
                            //when done with adventurer, repeatmenu should be set to
                            //false to get a different adventurer
                            //effectiveness determined by characters[characterIndex].Drinking

                            //the following method will prompt the user to choose a drink and calculate the 
                            //det damage done by that selection
                            Actions.Drink(characters[characterIndex]);

                            Console.WriteLine("Oopsie! This isn't done yet.");
                            int test1 = Actions.Drink(characters[characterIndex]);
                            Console.WriteLine("{0}'s drinking stat is {1}.", characters[characterIndex].FirstName, test1);
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.Oem2:
                            //TODO: Chat with adventurer
                            //when done with adventurer, repeatmenu should be set to
                            //false to get a different adventurer
                            //effectiveness determined by characters[characterIndex].Chatting
                            Console.WriteLine("Oopsie! This isn't done yet.");
                            int test2 = Actions.Chat(characters[characterIndex]);
                            Console.WriteLine("{0}'s chatting stat is {1}.", characters[characterIndex].FirstName, test2);
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.Oem3:
                            //TODO: Charm adventurer
                            //when done with adventurer, repeatmenu should be set to
                            //false to get a different adventurer
                            //effectiveness determined by characters[characterIndex].Flirting
                            Console.WriteLine("Oopsie! This isn't done yet.");
                            int test3 = Actions.Flirt(characters[characterIndex]);
                            Console.WriteLine("{0}'s flirting stat is {1}.", characters[characterIndex].FirstName, test3);
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.Oem4:
                            Console.WriteLine($"Today you are serving {characters[characterIndex].FirstName}" +
                                $" {characters[characterIndex].LastName}.");
                            Console.WriteLine($"{characters[characterIndex].Description}");
                            break;
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.Oem5:
                            //TODO: Display progress made by character and any information gathered about them
                            //repeatmenu remains true
                            Console.WriteLine("Oopsie! This isn't done yet.");
                            break;
                        case ConsoleKey.Escape:
                        case ConsoleKey.D6:
                        case ConsoleKey.NumPad6:
                        case ConsoleKey.Oem6:
                            Console.WriteLine("Alright, it's been fun. See you next time.\n\n\n");
                            repeatMenu = false;
                            exit = true;
                            break;
                        default:
                            break;
                    }
                    
                } while (repeatMenu);
                #endregion

                characterIndex++;
            } while (!exit);
            #endregion

            //TODO: if we track score in some way, we can put it here to display after exiting the main menu, before closing the game.

            #region components to use later
            /* This generates a random line of text as defined in
             * the method FlavorText's string array.
             * Console.WriteLine(FlavorText());
             */
            #endregion
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

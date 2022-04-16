using System;
using System.ComponentModel;

namespace Library
{
    public class Actions
    {   
        /// <summary>
        /// Given an adventurer object, Drink displays drink choices and prompts the user to choose one
        /// to offer the adventurer. Drink gets a user input and calculates the damage done to the 
        /// adventurer's determination based on the adventurer's preferences. This damage value is returned
        /// as an integer, and can then be subtracted from the adventurer's determination.
        /// </summary>
        /// <param name="adventurer"></param>
        /// <returns></returns>
        public static int Drink(Adventurer adventurer)
        {
            #region prompt user to select a drink
            Formatting.BartenderASCII();
            Console.WriteLine(
                $"{adventurer.FirstName} does look thirsty. Maybe they would appreciate it if\n" +
                $"you offered them a drink they would enjoy.\n");
            Formatting.BrightText();
            Console.WriteLine($"What will you suggest for {adventurer.FirstName}?");
            #endregion

            #region print drink names from enum DrinkOptions into menu
            int count = 1;
            foreach (var drinkName in Enum.GetNames(typeof(DrinkOptions)))
            {
                Console.Write($"{count}) {drinkName} ");
                count++;
            }
            Console.WriteLine("\n");
            Formatting.DarkText();
            #endregion

            #region looping menu switch gets valid menu selection + damage value
            bool selectionValid = true;
            int damage = 0;
            do
            {
                //get user selection as console key
                ConsoleKey menuSelection = Console.ReadKey(true).Key;

                //execute corresponding actions depending on selection
                switch (menuSelection)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.Oem1:
                        if ((DrinkOptions)0 == adventurer.Drink1)
                        {
                            Console.WriteLine("Hooray!! You did it!! You guessed their favorite drink!");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions) 0 == adventurer.Drink2)
                        {
                            Console.WriteLine("You guessed their second favorite drink!");
                            damage = adventurer.Drinking * 3;
                            selectionValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Hmm, they don't seem particularly interested.");
                            selectionValid = true;
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.Oem2:
                        if ((DrinkOptions)1 == adventurer.Drink1)
                        {
                            Console.WriteLine("Hooray!! You did it!! You guessed their favorite drink!");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)1 == adventurer.Drink2)
                        {
                            Console.WriteLine("You guessed their second favorite drink!");
                            damage = adventurer.Drinking * 3;
                            selectionValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Hmm, they don't seem particularly interested.");
                            selectionValid = true;
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.Oem3:
                        if ((DrinkOptions)2 == adventurer.Drink1)
                        {
                            Console.WriteLine("Hooray!! You did it!! You guessed their favorite drink!");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)2 == adventurer.Drink2)
                        {
                            Console.WriteLine("You guessed their second favorite drink!");
                            damage = adventurer.Drinking * 3;
                            selectionValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Hmm, they don't seem particularly interested.");
                            selectionValid = true;
                        }
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.Oem4:
                        if ((DrinkOptions)3 == adventurer.Drink1)
                        {
                            Console.WriteLine("Hooray!! You did it!! You guessed their favorite drink!");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)3 == adventurer.Drink2)
                        {
                            Console.WriteLine("You guessed their second favorite drink!");
                            damage = adventurer.Drinking * 3;
                            selectionValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Hmm, they don't seem particularly interested.");
                            selectionValid = true;
                        }
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.Oem5:
                        if ((DrinkOptions)4 == adventurer.Drink1)
                        {
                            Console.WriteLine("Hooray!! You did it!! You guessed their favorite drink!");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)4 == adventurer.Drink2)
                        {
                            Console.WriteLine("You guessed their second favorite drink!");
                            damage = adventurer.Drinking * 3;
                            selectionValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Hmm, they don't seem particularly interested.");
                            selectionValid = true;
                        }
                        break;
                    default:
                        Formatting.BrightText();
                        Console.WriteLine("Sorry, what drink did you want to offer them?\n" +
                            "(Enter a number from the menu options above)\n");
                        Formatting.DarkText();
                        selectionValid = false;
                        break;
                }
            } while (!selectionValid);
            #endregion
            
            return damage;
        }

        /// <summary>
        /// Given an adventurer object, Chat displays dialogue options for the user.
        /// Chat then gets a user input selection and calculates its effectiveness
        /// based on the adventurer's preferences. An integer damage value is returned, 
        /// which can be subtracted from the adventurer's determination. Currently this method 
        /// is only selecting an appropriate greeting, but features will be added to allow more complex, branching dialogue options.
        /// </summary>
        /// <param name="adventurer"></param>
        /// <returns></returns>
        public static int Chat(Adventurer adventurer)
        {
            #region prompt user to select a greeting
            Formatting.BartenderASCII();
            Formatting.BrightText();
            Console.WriteLine("How will you address your patron?");
            #endregion

            #region print greeting options from enum GreetingOptions into menu            
            int count = 1;
            foreach (var greeting in Enum.GetNames(typeof(GreetingOptions)))
            {                
                GreetingOptions menuEnum = (GreetingOptions)Enum.Parse(typeof(GreetingOptions), greeting);
                Console.Write($"{count}) {GreetingOptionsExtensions.DisplayText(menuEnum)}  ");
                count++;
            }

            Console.WriteLine("\n");
            Formatting.DarkText();
            #endregion

            #region looping menu switch gets valid menu selection + damage value
            bool selectionValid = true;
            int damage = 0;
            do
            {
                //get user selection as console key
                ConsoleKey menuSelection = Console.ReadKey(true).Key;

                //execute corresponding actions depending on selection
                switch (menuSelection)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.Oem1:
                        if ((GreetingOptions)0 == adventurer.Greeting)
                        {
                            Console.WriteLine("They seem quite pleased by your greeting.");
                            damage = adventurer.Chatting * 3;
                        }
                        else if ((GreetingOptions)0 == adventurer.HatedGreeting)
                        {
                            Console.WriteLine("You have just earned yourself a powerful scowl.");
                            adventurer.Determination += (adventurer.MaxDetermination - adventurer.Determination) / 2;
                        }
                        else
                        {
                            Console.WriteLine("You appear to have their attention.");
                        }
                        selectionValid = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.Oem2:
                        if ((GreetingOptions)1 == adventurer.Greeting)
                        {
                            Console.WriteLine("They seem quite pleased by your greeting.");
                            damage = adventurer.Chatting * 3;
                        }
                        else if ((GreetingOptions)1 == adventurer.HatedGreeting)
                        {
                            Console.WriteLine("You have just earned yourself a powerful scowl.");
                            adventurer.Determination += (adventurer.MaxDetermination - adventurer.Determination) / 2;
                        }
                        else
                        {
                            Console.WriteLine("You appear to have their attention.");
                        }
                        selectionValid = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.Oem3:
                        if ((GreetingOptions)2 == adventurer.Greeting)
                        {
                            Console.WriteLine("They seem quite pleased by your greeting.");
                            damage = adventurer.Chatting * 3;
                        }
                        else if ((GreetingOptions)2 == adventurer.HatedGreeting)
                        {
                            Console.WriteLine("You have just earned yourself a powerful scowl.");
                            adventurer.Determination += (adventurer.MaxDetermination - adventurer.Determination) / 2;
                        }
                        else
                        {
                            Console.WriteLine("You appear to have their attention.");
                        }
                        selectionValid = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.Oem4:
                        if ((GreetingOptions)3 == adventurer.Greeting)
                        {
                            Console.WriteLine("They seem quite pleased by your greeting.");
                            damage = adventurer.Chatting * 3;
                        }
                        else if ((GreetingOptions)3 == adventurer.HatedGreeting)
                        {
                            Console.WriteLine("You have just earned yourself a powerful scowl.");
                            adventurer.Determination += (adventurer.MaxDetermination - adventurer.Determination) / 2;
                        }
                        else
                        {
                            Console.WriteLine("You appear to have their attention.");
                        }
                        selectionValid = true;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.Oem5:
                        if ((GreetingOptions)4 == adventurer.Greeting)
                        {
                            Console.WriteLine("They seem quite pleased by your greeting.");
                            damage = adventurer.Chatting * 3;
                        }
                        else if ((GreetingOptions)4 == adventurer.HatedGreeting)
                        {
                            Console.WriteLine("You have just earned yourself a powerful scowl.");
                            adventurer.Determination += (adventurer.MaxDetermination - adventurer.Determination) / 2;
                        }
                        else
                        {
                            Console.WriteLine("You appear to have their attention.");
                        }
                        selectionValid = true;
                        break;
                    default:
                        Formatting.BrightText();
                        Console.WriteLine("Sorry, what drink did you want to offer them?\n" +
                            "(Enter a number from the menu options above)");
                        Formatting.DarkText();
                        selectionValid = false;
                        break;
                }
            } while (!selectionValid);
            #endregion
            
            return damage;
        }

        /// <summary>
        /// Given an adventurer object, Flirt gets a user input and calculates its effectiveness.
        /// Then, an integer damage value is returned, which can be subtracted from the adventurer's
        /// determination.
        /// </summary>
        /// <param name="adventurer"></param>
        /// <returns></returns>
        public static int Flirt(Adventurer adventurer)
        {
            int damage = 0; //placeholder
            return damage;
        }
                
        /// <summary>
        /// Given an adventurer object, detStatus calculates their current percentage of 
        /// determination. detStatus then displays a message to the user providing a vague indication of 
        /// how much determination they currently have left.
        /// </summary>
        /// <param name="adventurer"></param>
        /// <returns></returns>
        public static string detStatus(Adventurer adventurer)
        {
            string status;
            if ((adventurer.Determination / adventurer.MaxDetermination) > .75m)
            {
                status = "They are determined to complete their mission.";
            }
            else if ((adventurer.Determination / adventurer.MaxDetermination) > .40m)
            {
                status = "They are considering what you have to say.";
            }
            else if ((adventurer.Determination / adventurer.MaxDetermination) > .15m)
            {
                status = "Their resolve is wavering.";
            }
            else
            {
                status = "They seem to be full of doubt.";
            }
            return status;
        }

        /// <summary>
        /// Plays the Final Fantasy victory theme.
        /// </summary>
        public static void PlaySong()
        {
            Console.Beep(987, 153);
            Console.Beep(987, 153);
            Console.Beep(987, 153);
            Console.Beep(987, 900);
            Console.Beep(784, 900);
            Console.Beep(880, 900);
            Console.Beep(987, 700);
            Console.Beep(880, 300);
            Console.Beep(987, 700);
            Thread.Sleep(500);
        }
        
        /// <summary>
        /// Stores an array of text options that can be selected at random. 
        /// Can be used to provide variety within repeated dialogue responses.
        /// </summary>
        /// <returns></returns>
        public static string FlavorText()
        {
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

using System;
using System.ComponentModel;

namespace Library
{
    public class Actions
    {   
        /// <summary>
        /// Given an adventurer object, Chat displays dialogue options for the user.
        /// Chat then gets a user input selection and calculates its effectiveness
        /// based on the adventurer's preferences. An integer damage value is returned, 
        /// which can be subtracted from the adventurer's determination. 
        /// </summary>
        /// <param name="adventurer"></param>
        /// <returns></returns>
        public static int Greet(Adventurer adventurer)
        {
            #region print greeting options from enum GreetingOptions into menu       
            Formatting.BrightText();
            Console.WriteLine("\nHow will you address your patron?\n");
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
                        Console.WriteLine("Sorry, how did you want to greet them?\n" +
                            "(Enter a number from the menu options above)");
                        Formatting.DarkText();
                        selectionValid = false;
                        break;
                }
            } while (!selectionValid);
            #endregion
            Console.WriteLine();
            Formatting.Typewrite(adventurer.AdChat1);
            return damage;
        }

        /// <summary>
        /// Given an adventurer object, Convince displays ways to convince the adventurer.
        /// Gets user input selection and calculates its effectiveness based on adventurer preferences
        /// which are stored in properties Adventurer.Convince1 and Adventurer.Convince2. 
        /// Returns integer damage value which can be subtracted from adventurer's determination.
        /// </summary>
        /// <param name="adventurer"></param>
        /// <returns></returns>

        public static int Convince(Adventurer adventurer)
        {
            Formatting.BrightText();
            Console.WriteLine("\nHow will you convince them to stay safe?\n");

            //print choices
            Console.WriteLine($"1) Logic   2) Charm   3) Fear   4) Distract\n");

            Formatting.DarkText();

            bool selectionValid = true;
            int damage = 0;
            do
            {
                //get user selection as console key
                ConsoleKey menuSelection = Console.ReadKey(true).Key;

                //execute corresponding actions depending on selection
                switch (menuSelection)
                {
                    //logic
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.Oem1:
                        if (adventurer.Convince1 == 1)
                        {
                            Console.WriteLine($"Your words have great effect. {adventurer} is becoming greatly conflicted.");
                            damage = adventurer.Chatting * 5;
                        }
                        else if (adventurer.Convince2 == 1)
                        {
                            Console.WriteLine($"{adventurer} says you do have a point. They are deliberating.");
                            damage = adventurer.Chatting * 3;
                        }
                        else
                        {
                            Console.WriteLine("They appear unaffected by your attempts to discourage them.");
                        }
                        selectionValid = true;
                        break;
                    //charm
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.Oem2:
                        if (adventurer.Convince1 == 2)
                        {
                            Console.WriteLine($"Your words have great effect. {adventurer} is becoming greatly conflicted.");
                            damage = adventurer.Chatting * 5;
                        }
                        else if (adventurer.Convince2 == 2)
                        {
                            Console.WriteLine($"{adventurer} says you do have a point. They are deliberating.");
                            damage = adventurer.Chatting * 3;
                        }
                        else
                        {
                            Console.WriteLine("They appear unaffected by your attempts to discourage them.");
                        }
                        selectionValid = true;
                        break;
                    //fear
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.Oem3:
                        if (adventurer.Convince1 == 3)
                        {
                            Console.WriteLine($"Your words have great effect. {adventurer} is becoming greatly conflicted.");
                            damage = adventurer.Chatting * 5;
                        }
                        else if (adventurer.Convince2 == 3)
                        {
                            Console.WriteLine($"{adventurer} says you do have a point. They are deliberating.");
                            damage = adventurer.Chatting * 3;
                        }
                        else
                        {
                            Console.WriteLine("They appear unaffected by your attempts to discourage them.");
                        }
                        selectionValid = true;
                        break;
                    //distract
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.Oem4:
                        if (adventurer.Convince1 == 4)
                        {
                            Console.WriteLine($"Your words have great effect. {adventurer} is becoming greatly conflicted.");
                            damage = adventurer.Chatting * 5;
                        }
                        else if (adventurer.Convince2 == 4)
                        {
                            Console.WriteLine($"{adventurer} says you do have a point. They are deliberating.");
                            damage = adventurer.Chatting * 3;
                        }
                        else
                        {
                            Console.WriteLine("They appear unaffected by your attempts to discourage them.");
                        }
                        selectionValid = true;
                        break;
                    default:
                        Formatting.BrightText();
                        Console.WriteLine("Sorry, how did you want to convince them?\n" +
                            "(Enter a number from the menu options above)");
                        Formatting.DarkText();
                        selectionValid = false;
                        break;
                }
            } while (!selectionValid);

            Console.WriteLine();

            //adventurer response

            return damage;
        }

        /// <summary>
        /// Given an adventurer object, Drink displays drink choices dynamically from the DrinkOptions enum
        /// and prompts the user to choose one to offer the adventurer. Drink gets a user input and calculates 
        /// the damage done to the adventurer's determination based on the adventurer's preferences. This 
        /// damage value is returned as an integer, and can then be subtracted from the adventurer's determination. 
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
                            Console.WriteLine("They seem very pleased with your selection, and seem\n" +
                                "inclined to stick around a bit longer for another drink.");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions) 0 == adventurer.Drink2)
                        {
                            Console.WriteLine("They do seem to like this drink, but they still seem about ready to call it a night.");
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
                            Console.WriteLine("They seem very pleased with your selection, and seem\n" +
                                "inclined to stick around a bit longer for another drink.");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)1 == adventurer.Drink2)
                        {
                            Console.WriteLine("They do seem to like this drink, but they still seem about ready to call it a night.");
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
                            Console.WriteLine("They seem very pleased with your selection, and seem\n" +
                                "inclined to stick around a bit longer for another drink.");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)2 == adventurer.Drink2)
                        {
                            Console.WriteLine("They do seem to like this drink, but they still seem about ready to call it a night.");
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
                            Console.WriteLine("They seem very pleased with your selection, and seem\n" +
                                "inclined to stick around a bit longer for another drink.");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)3 == adventurer.Drink2)
                        {
                            Console.WriteLine("They do seem to like this drink, but they still seem about ready to call it a night.");
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
                            Console.WriteLine("They seem very pleased with your selection, and seem\n" +
                                "inclined to stick around a bit longer for another drink.");
                            damage = adventurer.Drinking * 5;
                            selectionValid = true;
                        }
                        else if ((DrinkOptions)4 == adventurer.Drink2)
                        {
                            Console.WriteLine("They do seem to like this drink, but they still seem about ready to call it a night.");
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
                Console.WriteLine();
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
        public static string Status(Adventurer adventurer)
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

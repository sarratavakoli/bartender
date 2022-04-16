using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.ComponentModel;


namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bartender ~ Can you save them?";

            Console.SetWindowSize(61, 40);

            #region characters initialized
            //for now, we are only working with one adventurer and he is added to the list
            //to be accessed throughout the system.  ahhh
            Adventurer player = new Adventurer();
            Adventurer bilbo = new Adventurer("Bilbo", "Baggins",
                "One of a race of creatures about half the size of humans,\n" +
                "beardless and with hairy feet. He has a pipe at the ready.\n" +
                "He doesn't really appear to be an adventurer at all.", 100, 7, 10, 1,
                DrinkOptions.Tea, DrinkOptions.Cider,
                "Well you see, this very tall and pushy wizard showedup to" +
                "my home and somehow we went from a very nice, cozy cup of" +
                "tea and puffing on our pipes  to… well, to me being" +
                "responsible for helping to save the world. I’m really" +
                "not sure how it all happened, to be honest.", 
                GreetingOptions.Good_Sir, GreetingOptions.My_Lady);
            List<Adventurer> characters = new List<Adventurer>() {bilbo};
            #endregion

            #region introduction
            Formatting.BartenderASCII();
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey(true);
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
            Formatting.BartenderASCII();
            Console.WriteLine("YOU are the tavern's trusty bartender.\n");
            Formatting.Bright("So what is your full name?");

            ConsoleKey confirmName;
            do
            {
                //get and split name input into first and last names
                Console.WriteLine();
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

                //confirm name
                Console.WriteLine($"\n{player.FirstName}, huh? ... I see, aren't you an odd one.\n");
                Formatting.Bright("Did I get your full name right? (Y/N)");
                confirmName = Console.ReadKey(true).Key;
                switch (confirmName)
                {
                    case ConsoleKey.Y:
                        break;
                    case ConsoleKey.N:
                        Formatting.Bright("\nAlright, let's try that again. What is your full name?");
                        break;
                    default:
                        Console.WriteLine("\nWhat was that? I don't understand. Let's try that again.\n");
                        Formatting.Bright("What is your full name?");
                        break;
                }
            } while (confirmName != ConsoleKey.Y);
            #endregion

            #region introduction to main menu
            Formatting.BartenderASCII();
            Console.WriteLine($"\nExcellent. Nice to meet you bartender {player.FirstName}. I know");
            Console.WriteLine("You just got here but it's time to get to work.");
            #endregion

            #region main game loop 
            int characterIndex = 0;
            bool exit = false;
            //initialize index before loop and increment after so that breaking out of the loop and
            //re-entering it will grant you an encounter with the next adventurer in the character list
            do 
            {
                Console.WriteLine("Someone is waiting for you.\n");
                Console.WriteLine(characters[characterIndex].Description);

                #region menu loop 
                bool repeatMenu = true;
                do 
                {
                    #region display menu, get selection
                    //display menu
                    Formatting.BartenderASCII();
                    Formatting.Bright("\nWhat will you do?\n" + 
                       $"1) Say hello\n" +
                       $"2) Offer them a drink\n" +
                       $"3) Review your status with {characters[characterIndex]}\n" +
                       $"4) Exit game\n");
                    //get input
                    ConsoleKey menuSelection = Console.ReadKey(true).Key;
                    #endregion

                    //switch on ConsoleKey input
                    switch (menuSelection)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.Oem1:
                            int chatDmg = Actions.Chat(characters[characterIndex]); 
                            Console.WriteLine($"You reduced {characters[characterIndex].FirstName}'s determination by {chatDmg}!");
                            characters[characterIndex].Determination -= chatDmg;
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.Oem2:
                            int drinkDmg = Actions.Drink(characters[characterIndex]);
                            Console.WriteLine($"You reduced {characters[characterIndex].FirstName}'s determination by {drinkDmg}!");
                            characters[characterIndex].Determination -= drinkDmg;
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.Oem3:
                            Console.WriteLine($"Today you are serving {characters[characterIndex].FirstName} {characters[characterIndex].LastName}.\n");
                            Console.WriteLine($"{characters[characterIndex].Description}\n");
                            Console.WriteLine($"{Actions.detStatus(characters[characterIndex])}");
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.Oem4:
                            Console.WriteLine("You can't be serious, you lazy bartender. I see how it\n" +
                                "is, just let all these adventurers get themselves killed.\n\n\n");
                            repeatMenu = false;
                            exit = true;
                            break;
                        default:
                            Formatting.BrightText();
                            Console.WriteLine("Sorry, I didn't get that. What would you like to do?");
                            break;
                    }
                    //after making a menu selection and processing the outcome of that selection, respond to 
                    //user if they completed the encounter and break out of the menu loop so that a new 
                    //adventurer can be selected to interact with.
                    if (characters[characterIndex].Determination <= 0)
                    {
                        Formatting.Bright($"\nWow, good job! You convinced {characters[characterIndex].FirstName} not to go get\n" +
                            $"themselves killed on their stupid impossible mission.\n" +
                            $"This world needs more bartenders like you!");
                        repeatMenu = false;
                        exit = true;
                    }
                    else 
                    {
                        Console.ReadKey(true);
                    }
                } while (repeatMenu); //menu loop continues while repeatMenu = true;
                #endregion

                characterIndex++;

            } while (!exit); //main game loop continues while exit = false
            #endregion

            #region display goodbye message and adventurers saved
            Actions.PlaySong();
            Formatting.Bright(
                $"\nFor now, your journey ends here. Soon, you will meet many\n" +
                $"other adventurers that are in dire need of your wise words\n" +
                $"and stiff drinks!");
            Console.WriteLine($"\nYou saved {characterIndex - 1} {((characterIndex - 1) > 1 ? "adventurers" : "adventurer")} from their almost definite doom.\n\n");
            #endregion

        }        
    }
}

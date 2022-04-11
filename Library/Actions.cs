namespace Library
{
    public class Actions
    {        
        //the following 3 methods are used to calculate how much determination 
        //will be lost after the interaction with the main character.
        //
        //currently they are just returning the static character's attribute
        //like chatting, drinking, or flirting
        //
        //however, the goal is to get a value from the interaction (like choosing a drink)
        //which will vary depending on what the player chooses
        //
        //then the calculations below will use that value in a calculation along with the 
        //adventurer's chatting/flirting/drinking/etc values to produce an integer
        //which will represent the determination reduced from the interaction.
        
        public static int Drink(Character adventurer)
        {
            //TODO perform calculation to determine damage done by choosing correct drink
            //reduce adventurer's Determination by factor of Drinking
            //return damage done to their determination
            int damage = 5;
            
            Console.WriteLine($"{adventurer.FirstName} looks thirsty. Maybe they'll feel better if you\n" +
                $"offered them a drink they enjoy.");
            
            string drinkChoice = (Console.ReadLine()).ToLower();
            
            Console.WriteLine("Drink choice as a string: " + drinkChoice);

            //if you guess the first, second, or otherwise anything else
            //the calculation will be adventurer.Drinking multiplied by a different value
            //depending on if you guessed their first choice or not
            //example:
            //bilbo baggins has only 10 det
            //we want buying him the right drink to give do about 2-3 damage
            //
            if (Enum.Parse<DrinkOptions>(drinkChoice) == adventurer.Drink1)
            {

            }
            else if (Enum.Parse<DrinkOptions>(drinkChoice) == adventurer.Drink2)
            {

            }
            else
            {

            }
                           
            //switch (switch_on)
            //{
            //    default:
            //}
            return damage;
        }
        public static int Chat(Character adventurer)
        {
            //TODO perform calculation to determine damage done by chatting
            //reduce adventurer's Determination by factor of Chatting
            //return damage done to their determination
            return adventurer.Chatting;
        }
        public static int Flirt(Character adventurer)
        {
            //TODO perform calculation to determine damage done by your charming efforts
            //reduce adventurer's Determination by factor of Flirting
            //return damage done to their determination
            return adventurer.Flirting;
        }
    }
}

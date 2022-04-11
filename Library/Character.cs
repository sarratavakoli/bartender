namespace Library
{
    public class Character
    {
        //fields

        //properties
        public string FirstName;
        public string LastName;
        public string Description;

        //determination points must be depleted to discourage
        //essentially this is HP
        public int Determination;

        //the following stats determine susceptibility to player efforts
        //currently scaled from 1-10 where 10 high susceptibility
        public int Drinking; //tied to giving them drinks they like 
        public int Chatting; //tied to making a good argument with them
        public int Flirting; //tied to being charmed

        //the following properties determine the character's drink preferences from DrinkOptions
        //Drink1 is the favorite drink and Drink2 is the second best choice
        public DrinkOptions Drink1;
        public DrinkOptions Drink2;
        
        //constructors
        public Character(string firstName, string lastName, string description, 
            int determination, int drinking, int chatting, int flirting, 
            DrinkOptions drink1, DrinkOptions drink2)
        {
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            Determination = determination;
            Drinking = drinking;
            Chatting = chatting;
            Flirting = flirting;
            Drink1 = drink1;
            Drink2 = drink2;
        }
        public Character() { }

        //methods
        public override string ToString()
        {
            return FirstName;
        }
    }
}
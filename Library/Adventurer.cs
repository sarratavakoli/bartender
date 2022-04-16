namespace Library
{
    public class Adventurer
    {
        //fields
        private readonly int _maxDetermination;
        //determined by determination on construction to avoid entering 
        //both determination & max determination
        



        //properties
        public string FirstName;
        public string LastName;
        public string Description;

        //determination points must be depleted to discourage
        //essentially this is HP
        public int Determination;

        //the following stats determine susceptibility to player efforts
        //currently scaled from 1-10 where 10 indicates high susceptibility
        public int Drinking; //tied to giving them drinks they like 
        public int Chatting; //tied to making a good argument with them
        public int Flirting; //tied to being charmed

        //Drink1 is their favorite drink and Drink2 is their second favorite
        public DrinkOptions Drink1;
        public DrinkOptions Drink2;

        //static chat responses
        public string AdChat1; //adventurer's first dialogue blurb after being greeted

        //greeting preferences
        public GreetingOptions Greeting;
        public GreetingOptions HatedGreeting;
        //the above has negative damage effect aka strengthens determination
        //
        //determined by determination on construction
        public int MaxDetermination { get { return _maxDetermination; } }
        



        //constructors
        public Adventurer(string firstName, string lastName, string description, 
            int determination, int drinking, int chatting, int flirting, 
            DrinkOptions drink1, DrinkOptions drink2, string adChat1,
            GreetingOptions greeting, GreetingOptions hatedGreeting)
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
            AdChat1 = adChat1;
            Greeting = greeting;
            HatedGreeting = hatedGreeting;            
            _maxDetermination = determination;
        }
        public Adventurer() { }



        //methods
        public override string ToString()
        {
            return FirstName;
        }

    }
}
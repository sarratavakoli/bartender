namespace Library
{
    public class Adventurer
    {
        //FIELDS
        /// <summary>
        /// Upon construction, determination value is also assigned as MaxDetermination and remains
        /// a read-only class. Throughout the program, determination will be reduced or increased
        /// by player actions (similar to enemy health points in a typical enemy encounter) while
        /// MaxDetermination will remain the original value and enable percentage hp type calculations.
        /// </summary>
        private readonly int _maxDetermination;

        //PROPERTIES
        public string FirstName;
        public string LastName;
        public string Description;
        public int Determination; //essentially represents current health points
        public int Drinking; //susceptibility to effective drink choices
        public int Chatting; //susceptibility to effective chat choices
        public int Flirting; //susceptibility to effective flirting choices
        public DrinkOptions Drink1; //favorite drink choice
        public DrinkOptions Drink2; //second favorite drink choice
        
        public string AdChat1; //adventurer's first dialogue blurb after being greeted

        public GreetingOptions Greeting; //favorite greeting choice
        public GreetingOptions HatedGreeting; //hated greeting choice increases determination
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
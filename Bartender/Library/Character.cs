namespace Library
{
    public class Character
    {
        //fields

        //properties
        public string Name;
        public string Description;
        public int Determination; //determination points must be depleted to discourage

        //constructors
        public Character(string name, string description, int determination)
        {
            Name = name;
            Description = description;
            Determination = determination;
        }

        //methods
        public override string ToString()
        {
            return Name;
        }

    }
}
using System;

{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public Dictionary<string, int> Attributes { get; set; }

        public Character()
        {
            Name = "Reginald";
            Level = 25;
            HealthPoints = 200;
            Attributes.Add("IQ", 30);
            Attributes.Add("ME", 20);
            Attributes.Add("MA", 21);
            Attributes.Add("PS", 10);
            Attributes.Add("PP", 8);
            Attributes.Add("PE", 6);
            Attributes.Add("PB", 15);
            Attributes.Add("Spd", 10);  
        }

        public override string ToString()
        {
            StringBuilder charPrint = new StringBuilder();
            charPrint.Append($"{Name}                          ");
        }
    }
}
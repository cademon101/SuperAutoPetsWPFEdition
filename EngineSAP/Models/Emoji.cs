using System;
namespace EngineSAP.Models
{
    public abstract class Emoji
    {
        public string Name { get; private set; }
        public string Icon { get; private set; }
        public int Atk { get; private set; }
        public int Hp { get; private set; }

        public int Cost = 3;

        public Emoji(string name) //future implimtation public Miner() : base("Miner") { }
        {
            Name = name;

        }

    }
}

using System;
//namespace EngineSAP.Models;
using System.ComponentModel;
using System.Xml.Linq;

namespace EngineSAP.Models
{
    public abstract class Emoji : INotifyPropertyChanged
    {
        public string Name { get; private set; }
        public string Icon { get; private set; }
        public int atk { get; set; }
        private int hp { get; set; }
        private int cost = 3;
        private int level = 1;

        public int Atk
        {
            get { return atk; }
            set
            {
                atk = value;
                OnPropertyChanged("Atk");
            }
        }
        public int Hp
        {
            get { return hp; }
            set
            {
                hp = value;
                OnPropertyChanged("Hp");
            }
        }
        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                OnPropertyChanged("Atk");
            }
        }


        public Emoji(string name) //future implimtation public Miner() : base("Miner") { }
        {
            Name = name;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void takeDamage(int damage)
        { 
            hp =- damage;
            OnPropertyChanged("Hp");
        }
        public void LevelUp() 
        {
        //fill this out later
        }


    }
}

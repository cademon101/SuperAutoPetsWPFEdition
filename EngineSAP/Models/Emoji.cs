using System;
//namespace EngineSAP.Models;
using System.ComponentModel;
using System.Xml.Linq;

namespace EngineSAP.Models
{
    public abstract class Emoji : INotifyPropertyChanged
    {
        public string Name { get; set; } //toresearch[][R]
        public string Icon { get; set; }
        public int atk { get; set; }
        private int hp { get; set; }
        private int cost = 3;
        private int level = 1;
        public bool isAlive = true;

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
        public bool IsAlive
        {
            get { return isAlive; }
            set
            {
                isAlive = value;
                OnPropertyChanged($"{nameof(IsAlive)}");
            }
        }

        public Emoji(string name, string icon, int hp, int atk) //future implimtation public Miner() : base("Miner") { }
        {
            Name = name;
            Icon = icon;
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
            if (hp <= 0) 
            {
                isAlive=false;
                OnPropertyChanged("IsAlive");
            }
        }
        public void healDamage(int toHeal)
        {
            hp =+ toHeal;
            OnPropertyChanged("Hp");
        }
        public void LevelUp() 
        {
            level++;
            onLevelUp();
        }
        public abstract void onLevelUp();
        public abstract void ability();

    }
}

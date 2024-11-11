
using System.ComponentModel;
using System.Xml.Linq;

namespace EngineSAP.Models
{
    //Decideing if this should hold player data only or what methods should it hold?
    public class Player : INotifyPropertyChanged 
    {
        string name { get; set; } //[][todo] random game gen
        int gold { get; set; } //[][todo] there's some sort of encapslation thing with this
        int score { get; set; }
        string hP { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
                OnPropertyChanged("Gold");
            }
        }
        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                OnPropertyChanged("Score");
            }
        }
        public string HP
        {
            get { return hP; }
            set
            {
                hP = value;
                OnPropertyChanged("HP");
            }
        }
        List<Emoji> PlayerTeam { get; set; }

        public Player() //[][todo] have an event handler for this too!
        {
            PlayerTeam = new List<Emoji>();
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
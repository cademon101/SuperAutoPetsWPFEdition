
using System.ComponentModel;
using System.Xml.Linq;

namespace EngineSAP.Models
{
    //Decideing if this should hold player data only or what methods should it hold?
    public class Player : INotifyPropertyChanged
    {
        string name { get; set; } //[][todo] random game gen
        int gold { get; set; } //[][toLearn] there's some sort of encapslation thing with this
        int score { get; set; }
        string[] hP { get; set; }
        private int lossCounter = 10; 

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
            get { return string.Join(" ", hP); }
            set
            {
                hP = value.Split(new[] { " " }, StringSplitOptions.None);
                OnPropertyChanged("HP");
            }
        }
        List<Emoji> PlayerTeam { get; set; }

        public Player() //[][todo] have an event handler for this too!
        {
            hP = ["❤️", "❤️", "❤️", "❤️", "❤️", "❤️", "❤️", "❤️", "❤️", "❤️"];
            PlayerTeam = new List<Emoji>();
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SubtractHeart()
        {
            if (lossCounter > 0)
            {
                lossCounter--;
                hP[lossCounter] = "💔";
                OnPropertyChanged("HP"); //[][toLearn] do I need to call this each time on prop changed

            }
            else { LostGame(); } //lose condition I dont think we ever reach this
        }
        public void LostGame()
        {
            //[][to do] Fill this out
        }
    }
}
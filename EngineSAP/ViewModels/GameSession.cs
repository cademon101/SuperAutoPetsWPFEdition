using EngineSAP.Models;


    namespace EngineSAP.ViewModels
    {
        public class GameSession
        {
            public Player CurrentPlayer { get; set; }
            public GameSession()
            {
                CurrentPlayer = new Player();
                CurrentPlayer.Gold = 10;
                CurrentPlayer.Score = 0;
                CurrentPlayer.HP = "❤❤❤❤❤❤❤❤❤❤"; //[][todo] System for dynamicly changing the hearts
                
            }
        }
    }

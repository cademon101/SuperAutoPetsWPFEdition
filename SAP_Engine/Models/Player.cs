namespace SAP_Engine
{
    //Decideing if this should hold player data only or what methods should it hold?
    public class Player
    {
        string Name { get; set; } //[][todo] random 
        int HitPoints { get; set; }
        int Score { get; set; }
        int HP { get; set; }
        int Gold { get; set; }

        public List<Emoji> PlayerTeam { get; set; }

        public Player()
        {
            PlayerTeam = new List<Emoji>();
        }
    }
}
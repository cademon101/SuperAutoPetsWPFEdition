using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSAP.Models.EmojiList
{
    internal class Ant : Emoji
    {
       public Ant() : base("ant", "🐜", 2, 2) { }
       public override void onLevelUp() 
       {
           throw new NotImplementedException();
       }
       public override void ability()
       {
           throw new NotImplementedException();
       }
    }
}

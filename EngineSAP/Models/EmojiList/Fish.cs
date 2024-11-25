using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSAP.Models.EmojiList
{
    internal class Fish : Emoji
    {
        public Fish() : base("fish", "🐟", 2, 3) { }
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

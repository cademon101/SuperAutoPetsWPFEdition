using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSAP.Models.EmojiList
{
    internal class Bever : Emoji
    {
        public Bever() : base("bever", "🦫", 2, 3) { }
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

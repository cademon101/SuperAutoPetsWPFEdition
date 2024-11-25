using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSAP.Models.EmojiList
{
    internal class Cricket : Emoji
    {
        public Cricket() : base("cricket", "🦗", 2, 1) { }
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

using System;
using System.Collections.ObjectModel;
namespace EngineSAP.Models
{
    public class Team
    {
        ObservableCollection<Emoji> EmojiTeam = new ObservableCollection<Emoji>();
        void AddTeamMember(Emoji newEmoji)
        {
            if (EmojiTeam.Count >= 5)
            {
                return; //[][todo] Error handeling
            }
            var existingEmoji = EmojiTeam.FirstOrDefault(e => e.Name == newEmoji.Name);
            if (existingEmoji != null)
            {
                newEmoji.LevelUp();
            }
            else
            {
                EmojiTeam.Add(newEmoji);
            }
        }
        void SubtractMember(Emoji emojiToSubtract)
        {
            EmojiTeam.Remove(emojiToSubtract);
        }
        void SwapMembers(int index1, int index2)
        {
            var tempMember = EmojiTeam[index1];
            EmojiTeam[index1] = EmojiTeam[index2];
            EmojiTeam[index2] = tempMember;
        }
    }
}
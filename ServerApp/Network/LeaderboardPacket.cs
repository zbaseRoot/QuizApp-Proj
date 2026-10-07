using System.Collections.Generic;

namespace Network
{
    public class LeaderboardPacket
    {
        public string QuizTitle { get; set; }
        public List<LeaderboardItem> Records { get; set; }

        public LeaderboardPacket()
        {
            Records = new List<LeaderboardItem>();
        }
    }
}

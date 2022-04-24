namespace AManager
{
    public class Achievements
    {
        public struct Achievementcollection
        {
            public string Name { get; set; }
            public string Statements { get; set; }
            public bool IsAchieved { get; set; }

            public byte Difficulty { get; set; }
        }
        // 0 means common,1 means uncommon,2 means rare,3 means epic


        public Achievementcollection[] AchievementCollections = new Achievementcollection[13] ;
        public int TTimes;
    }

}

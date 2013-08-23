using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Threading;

namespace BattlePillars.XNA
{
    [DataContract]
    public class Savegame
    {
        [DataMember]
        public int Version;

        [DataMember]
        public bool SFXMuted;

        [DataMember]
        public bool MusicMuted;

        [DataMember]
        public Dictionary<short, LevelState> LevelStates;
        
        [DataMember]
        public Dictionary<short, TimeSpan> BestTimes;

        [DataMember]
        public List<int> TipsShown;

        [DataMember]
        public List<int> HighScores;

        [DataMember]
        public List<int> SkinsOwned;

        [DataMember]
        public List<int> TabsVisited;

        [DataMember]
        public Dictionary<SegmentType, int> PlayerSegmentLevels;

        [DataMember]
        public List<int> ChallengeLevelsCompleted;

        [DataMember]
        public Dictionary<BaseUpgradeType, int> PlayerBaseUpgradeLevels;

        [DataMember]
        public Dictionary<ExpendableType, int> ExpendablesOwned;

        [DataMember]
        public byte TotalLevelsDefeated;

        [DataMember]
        public int PlayerApples;

        [DataMember]
        public byte SegmentSlots;

        [DataMember]
        public bool VisitedStore;

        [DataMember]
        public bool SlotNagShown;

        [DataMember]
        public bool StoreNagShown;

        [DataMember]
        public List<int> SelectedSegments;

        [DataMember]
        public List<int> UnlockedSegments;

        [DataMember]
        public List<int> DefeatedEnvironments;

        [DataMember]
        public int Campaign1Skin;

        [DataMember]
        public int Team1Skin;

        [DataMember]
        public List<Skin> SpecialSkinsUnlocked;

        [DataMember]
        public int LastVisitedLevel;

        [DataMember]
        public DateTime LastDailyReward;

        [DataMember]
        public List<int> UnlockedModes;

    }
}


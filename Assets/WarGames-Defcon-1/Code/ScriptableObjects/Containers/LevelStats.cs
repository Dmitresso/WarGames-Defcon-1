using System;

namespace WarGames_Defcon_1.Code.ScriptableObjects.Containers {
    [Serializable]
    public class LevelStats {
        public DateTime time;
        public int troops;
        public int vehicles;
        public int buildings;
    }
}
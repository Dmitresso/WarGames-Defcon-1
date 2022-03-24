using System.Collections.Generic;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts;


namespace WarGames_Defcon_1.Code.ScriptableObjects {
    public class ScenesData : ScriptableObject {
        public List<GameScene> allScenes;
        public List<GameLevel> noradLevels;
        public List<GameLevel> woprLevels;

        private int maxLevel = 15;

        
        public void LoadLevel(Fraction fraction, int level) {
            if (level > maxLevel) {
                Debug.Log("[] Trying to load level " + level);
                return;
            }
            
            List<GameLevel> levels;
            switch (fraction) {
                case Fraction.NORAD:
                    levels = noradLevels;
                    break;
                case Fraction.WOPR:
                    levels = woprLevels;
                    break;
            }
        }
    }
}
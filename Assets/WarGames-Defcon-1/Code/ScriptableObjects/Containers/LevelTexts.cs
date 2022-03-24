using System;
using System.Collections.Generic;
using UnityEngine;


namespace WarGames_Defcon_1.Code.ScriptableObjects.Containers {
    [Serializable]
    public class LevelTexts {
        public TextAsset briefing;
        public TextAsset objectives;
        public TextAsset vehicles;
        public List<Description> descriptions;
        public List<TextAsset> email;
    }
}
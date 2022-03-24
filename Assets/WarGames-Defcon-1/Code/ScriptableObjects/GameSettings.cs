using UnityEngine;
using WarGames_Defcon_1.Code.Scripts;


namespace WarGames_Defcon_1.Code.ScriptableObjects {
    public class GameSettings {
        public Lang language;
        public Fraction fraction;
        [Range(0f, 1f)] public float musicVolume;
        [Range(0f, 1f)] public float sfxVolume;
        [Range(0f, 1f)] public float voiceVolume;
    }
}
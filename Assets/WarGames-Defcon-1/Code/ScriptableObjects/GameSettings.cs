using UnityEngine;
using WarGames_Defcon_1.Code.Scripts;


namespace WarGames_Defcon_1.Code.ScriptableObjects {
    public class GameSettings : ScriptableObject {
        public Lang language = Lang.ENG;
        public Fraction fraction = Fraction.NORAD;
        public GameType gameType = GameType.Campaign;
        [Range(0f, 1f)] public float musicVolume = 0.5f;
        [Range(0f, 1f)] public float sfxVolume = 0.5f;
        [Range(0f, 1f)] public float voiceVolume = 0.5f;
    }
}
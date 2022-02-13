using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Service {
    public static class Data {
        public struct Resources {
            public static void Init() {
                Music.Init();
            }
            
            
            public struct Music {
                public static AudioClip MainSoundtrack;
                public static AudioClip ButtonOnHoverSound, ButtonOnClickSound;

                private static readonly string mainSoundtrackPath = "Audio/Music/Main soundtrack";
                private static readonly string buttonOnHoverSoundPath = "Audio/SFX/1";
                private static readonly string buttonOnClickSoundPath = "Audio/SFX/2";

                public static void Init() {
                    MainSoundtrack = UnityEngine.Resources.Load(mainSoundtrackPath, typeof(AudioClip)) as AudioClip;
                    ButtonOnHoverSound = (AudioClip) UnityEngine.Resources.Load(buttonOnHoverSoundPath);
                    ButtonOnClickSound = (AudioClip) UnityEngine.Resources.Load(buttonOnClickSoundPath);
                }
            }


            public struct Text {
                public static string briefing;
                public static string objectives;
                public static string vehicles;
                public static string email;

                public static void Load(Lang language, Fraction fraction, int level) {
                    var maxLevel = 15;
                    if (level > maxLevel) {
                        Debug.Log("[] Trying to load level " + level);
                    }
                    var finalPath = language.ToString() + fraction;
                }
            }
        }
    }
}
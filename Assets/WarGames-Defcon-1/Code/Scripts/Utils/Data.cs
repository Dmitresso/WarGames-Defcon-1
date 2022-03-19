using System;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Game_Management;

namespace WarGames_Defcon_1.Code.Scripts.Utils {
    [DefaultExecutionOrder(-50)]
    public static class Data {
        public static void Init() {
            Resources.Init();
            Settings.Init();
        }


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
                    ButtonOnHoverSound = (AudioClip)UnityEngine.Resources.Load(buttonOnHoverSoundPath);
                    ButtonOnClickSound = (AudioClip)UnityEngine.Resources.Load(buttonOnClickSoundPath);
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


        public struct Settings {
            public static void Init() {
                Input.Init();
            }

            public struct Input {
                public const string Horizontal = "Horizontal";
                public const string Vertical = "Vertical";


                public static void Init() { }
            }
        }


        public struct Scenes {
            public static readonly string
                Main,
                Load,
                Game,
                Level1;

            static Scenes() {
                Main = SceneManager.GetSceneNameByIndex(0);
                Load = SceneManager.GetSceneNameByIndex(1);
                Game = SceneManager.GetSceneNameByIndex(2);
                Level1 = SceneManager.GetSceneNameByIndex(3);
            }

            private static string gameToLoad;

            public static string GameToLoad {
                get => gameToLoad;
                set {
                    var scenesList = "";
                    var scenes = typeof(Scenes).GetFields();
                    for (int i = 0; i < scenes.Length; i++) {
                        string tmp = i == scenes.Length - 1 ? "." : ", ";
                        string.Concat(scenesList, (string)scenes[i].GetValue(null) + tmp);
                        if (value == (string)scenes[i].GetValue(null)) gameToLoad = value;
                    }

                    if (gameToLoad == null) {
                        throw new Exception("Attempt of setting \"GameToLoad\" string value to \"" +
                                            value + "\" didn't find matching scene name in \"Scenes\" struct. " +
                                            "Available scenes: " + scenes);
                    }
                }
            }
        }
    }
}
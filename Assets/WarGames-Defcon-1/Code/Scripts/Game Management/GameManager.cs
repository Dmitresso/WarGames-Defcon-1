using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using WarGames_Defcon_1.Code.ScriptableObjects;
using WarGames_Defcon_1.Code.Scripts.Camera;
using WarGames_Defcon_1.Code.Scripts.Scene_Management;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.Utils;


namespace WarGames_Defcon_1.Code.Scripts.Game_Management {
    [DefaultExecutionOrder(-100)]
    [RequireComponent(typeof(DontDestroyOnLoad))]
    public class GameManager : Singleton<GameManager> {
        #region Fields
        [SerializeField] private GameObject[] systemPrefabs;

        private List<GameObject> instancedSystemPrefabs;
        private LevelManager currentLevelManager;
        private ICamera activeCamera;

        private GameSettings gameSettings;
        private ScenesData scenesData;
        #endregion



        #region Builtin Methods
        private void Awake() {
            instancedSystemPrefabs = new List<GameObject>();
            Data.Init();
            InstantiateSystemPrefabs();
            //levels = AssetDatabase.FindAssets(new[] {"Assets/WarGames-Defcon-1/ScriptableObjects/"});

            //scenesData = AssetDatabase.FindAssets("");
        }


        private void Start() {
            UnityEngine.SceneManagement.SceneManager.sceneLoaded += SceneManager.OnSceneLoaded;
            StartCoroutine(SceneManager.LoadScene(Data.Scenes.Main));
        }
        #endregion
        
        
        
        #region Custom Methods
        private void InstantiateSystemPrefabs() {
            foreach (var go in systemPrefabs) {
                var prefabInstance = Instantiate(go);
                instancedSystemPrefabs.Add(prefabInstance);
                DontDestroyOnLoad(this);
            }
        }


        private void ExitApp() {
            #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
            #endif
            Application.Quit();
        }


        public LevelManager GetActiveSceneLevelManager() {
            // todo
            return new LevelManager();
        }
        #endregion
    }
}
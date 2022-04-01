using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using WarGames_Defcon_1.Code.ScriptableObjects;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.Utils;


namespace WarGames_Defcon_1.Code.Scripts.Game_Management {
    [DefaultExecutionOrder(-100)]
    [RequireComponent(typeof(DontDestroyOnLoad))]
    public class GameManager : Singleton<GameManager> {
        #region Fields
        [SerializeField] private ScenesData scenesData;
        [SerializeField] private GameSettings gameSettings;
        [SerializeField] private GameObject[] systemPrefabs;

        private List<GameObject> instancedSystemPrefabs = new ();
        private LevelManager currentLevelManager;
        private GameLevel currentLevel;
        #endregion



        #region BUILTIN METHODS
        private void Awake() {
            InstantiateSystemPrefabs();
        }


        private void Start() {
            SceneManager.LoadScene(scenesData.mainMenu.name);
            
        }


        private void OnEnable() {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        
        
        private void OnDisable() {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
        #endregion



        #region CUSTOM METHODS
        protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) {
            if (scene.name == scenesData.mainMenu.name) {
                
                return;
            }

            var currentLevelManagerGO = FindObjectOfType<LevelManager>();
            if (currentLevelManagerGO == null) Debug.LogError("There's no LevelManager on level scene " + scene.name);
        }
        
        
        private void InstantiateSystemPrefabs() {
            foreach (var go in systemPrefabs) {
                var prefabInstance = Instantiate(go);
                prefabInstance.name = go.name;
                DontDestroyOnLoad(prefabInstance);
                instancedSystemPrefabs.Add(prefabInstance);
            }
        }


        private void ExitApp() {
            #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
            #endif
            Application.Quit();
        }
        #endregion
    }
}
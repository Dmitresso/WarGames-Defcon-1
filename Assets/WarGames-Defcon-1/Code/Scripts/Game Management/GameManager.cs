using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using WarGames_Defcon_1.Code.ScriptableObjects;
using WarGames_Defcon_1.Code.Scripts.Camera;
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
        private GameLevel currentLevel;
        private ICamera activeCamera;
        #endregion



        #region Builtin Methods
        private void Awake() {
            InstantiateSystemPrefabs();
        }


        private void Start() {
            SceneManager.LoadScene(scenesData.mainMenu.name);
        }
        #endregion
        
        
        
        #region Custom Methods
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
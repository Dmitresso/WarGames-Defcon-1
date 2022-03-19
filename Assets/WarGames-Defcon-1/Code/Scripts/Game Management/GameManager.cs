using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
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
        #endregion



        #region Builtin Methods
        private void Awake() {
            Data.Init();
            InstantiateSystemPrefabs();
        }
        #endregion
        
        
        
        #region Custom Methods
        private void InstantiateSystemPrefabs() {
            foreach (var go in systemPrefabs) {
                var prefabInstance = Instantiate(go);
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
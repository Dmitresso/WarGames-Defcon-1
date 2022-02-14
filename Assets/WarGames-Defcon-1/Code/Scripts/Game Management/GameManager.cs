﻿using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    public class GameManager : MonoBehaviour {
        #region Variables
        [SerializeField] private bool pausable = true;
        [SerializeField] private GameObject[] systemPrefabs;
        private List<GameObject> instancedSystemPrefabs;
        #endregion



        #region Builtin Methods
        private void Awake() {
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
using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.Utils;


namespace WarGames_Defcon_1.Code.Scripts.Game_Management {
    public static class SceneManager {
        private static AsyncOperation loadScene;
        private static LevelManager loadSceneLM, gameSceneLM;
        private static Coroutine loadScreenLoadingCoroutine;


        static SceneManager() { }

        
        private static LevelManager GetSceneLevelManager(string sceneName) {
            var gameObjects = UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName).GetRootGameObjects();
            foreach (var go in gameObjects)
                if (go.CompareTag(Tags.GM.GameManager))
                    return go.GetComponent<LevelManager>();
            throw new NullReferenceException("There's no \"Level Manager\" object on \"" + sceneName + "\" scene." );
        }
        
        
        public static string GetSceneNameByIndex(int index) {
            return Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(index));
        }

        
        public static IEnumerator LoadScene(string sceneName) {
            Data.Scenes.GameToLoad = sceneName;
            yield return new WaitForSeconds(0.1f);
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(Data.Scenes.Load);
            loadScene = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(Data.Scenes.GameToLoad);
            loadScene.allowSceneActivation = false;
        }

        
        public static void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
            if (scene.name == Data.Scenes.Load) {
                loadSceneLM = GetSceneLevelManager(Data.Scenes.Load);
                // loadScreenLoadingCoroutine = loadSceneGM.StartCoroutine(loadSceneGM.loadScreen.StartLoading());
                // loadSceneGM.loadScreen.LoadingFinished += ActivateGameScene;
            }
            else {
                if (loadScreenLoadingCoroutine != null) GetSceneLevelManager(scene.name).StopCoroutine(loadScreenLoadingCoroutine);
            }
        }
        
        
        private static void ActivateGameScene() {
            if (loadScene != null) {
                loadScene.allowSceneActivation = true;
            }
            else {
                var e = "loadscene is null. It's ok if \"LoadScene\" scene was launched in single mode.";
                throw new Exception(e);
            }
        }

        
        public static void ExitApp() {
            Application.Quit();
        }
    }
}
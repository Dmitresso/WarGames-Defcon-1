using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Service {
    public class Singleton<T> : MonoBehaviour where T : Singleton<T> {
        #region Variables
        private static T instance;
        #endregion



        #region Properties
        public static bool IsInit => instance != null;
        #endregion



        #region Builtin Methods
        protected void Awake() {
            if (instance != null) Debug.LogError("[Singleton] Trying to instantiate a second instance of " + typeof(T) + " class.");
        }

        
        protected virtual void OnDestroy() {
            if (instance == this) instance = null;
        }
        #endregion



        #region Custom Methods
        public static T Instance {
            get {
                if (instance == null) {
                    instance = (T) FindObjectOfType(typeof(T));

                    if (instance == null)
                        Debug.LogError("[Singleton] An instance of " + typeof(T) + " is needed in the scene, but there is none.");
                }
                return instance;
            }
        }
        #endregion
    }
}
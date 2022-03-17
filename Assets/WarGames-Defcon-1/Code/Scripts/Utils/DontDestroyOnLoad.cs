using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Utils {
    public class DontDestroyOnLoad : MonoBehaviour {
        [SerializeField] private bool dontDestroyOnLoad = true;

        public bool IsDestroyOnLoad => dontDestroyOnLoad;

        private void Awake() {
            if (dontDestroyOnLoad) DontDestroyOnLoad(gameObject);
        }
    }
}
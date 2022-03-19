using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.Utils;


namespace WarGames_Defcon_1.Code.Scripts {
    public class Initializer : MonoBehaviour {
        #region Properties
        public static bool InitCompleted { get; private set; }
        #endregion
        



        #region Builtin Methods
        private void Awake() {
            Data.Init();
        }
        #endregion


        
        #region Custom Methods
        public static void Init() {
            if (InitCompleted) return;
            Data.Init();
            InitCompleted = true;
        }
        #endregion
    }
}
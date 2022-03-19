using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input.Keys;
using WarGames_Defcon_1.Code.Scripts.Service;
using WarGames_Defcon_1.Code.Scripts.Utils;

namespace WarGames_Defcon_1.Code.Scripts.Input.ClassicInput {
    public class BaseInput : MonoBehaviour, IInputSystem {
        #region Fields
        protected float horizontal, vertical;

        private IKeys keys;
        #endregion



        #region Properties
        public float Horizontal => horizontal;
        public float Vertical => vertical;
        #endregion
        
        

        #region Builtin Methods
        private void Awake() {
            keys.Horizontal = Data.Settings.Input.Horizontal;
            keys.Vertical = Data.Settings.Input.Vertical;
        }


        private void Update() {
            HandleInputs();
        }
        #endregion



        #region Custom Methods
        public void HandleInputs() {
            horizontal = UnityEngine.Input.GetAxis(keys.Horizontal);
            vertical = UnityEngine.Input.GetAxis(keys.Vertical);
        }
        #endregion
    }
}
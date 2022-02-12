using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public class BaseInput : MonoBehaviour {
        #region Variables
        [SerializeField] protected Keys keys;
        protected float horizontal, vertical;
        #endregion



        #region Properties
        public float Horizontal => horizontal;
        public float Vertical => vertical;
        #endregion
        
        

        #region Builtin Methods
        private void Awake() {
            keys = new Keys(
                "Horizontal",
                "Vertical",
                KeyCode.Q,
                KeyCode.E,
                KeyCode.C,
                KeyCode.V,
                KeyCode.F,
                KeyCode.Mouse0,
                KeyCode.Mouse1
            );
        }


        private void Update() {
            HandleInputs();
        }
        #endregion



        #region Custom Methods
        protected virtual void HandleInputs() {
            horizontal = UnityEngine.Input.GetAxis(keys.horizontal);
            vertical = UnityEngine.Input.GetAxis(keys.vertical);
        }
        #endregion
    }
}
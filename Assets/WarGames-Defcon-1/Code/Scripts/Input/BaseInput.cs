using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public class BaseInput : MonoBehaviour {
        #region Variables
        [SerializeField] protected InputKeys InputKeys = new(
            "horizontal",
            "vertical",
            KeyCode.W,
            KeyCode.S,
            KeyCode.A,
            KeyCode.D,
            KeyCode.Q,
            KeyCode.E,
            KeyCode.C,
            KeyCode.V,
            KeyCode.F,
            KeyCode.Mouse0,
            KeyCode.Mouse1
            );

        protected float horizontal, vertical;
        #endregion



        #region Builtin Methods

        private void Update() {
            HandleInputs();
        }

        #endregion



        #region Custom Methods

        private void HandleInputs() {
            horizontal = UnityEngine.Input.GetAxis(InputKeys.horizontal);
            vertical = UnityEngine.Input.GetAxis(InputKeys.vertical);
        }

        #endregion
        
    }
}
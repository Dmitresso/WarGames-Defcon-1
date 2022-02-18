using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input.ClassicInput;
using WarGames_Defcon_1.Code.Scripts.Input.Keys;


namespace WarGames_Defcon_1.Code.Scripts.Input.InputType {
    public class XboxInput : BaseInput {
        #region Variables
        [SerializeField] protected XboxKeys xboxKeys;
        #endregion


        
        #region Custom Methods
        public void ProvideInputs() {
            Debug.Log("XBOX");
        }
        #endregion
    }
}
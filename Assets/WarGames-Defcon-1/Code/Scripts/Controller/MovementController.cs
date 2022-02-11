using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    public class MovementController : MonoBehaviour {
        #region Variables
        [SerializeField] private float torqueForce = 5f;
        [SerializeField] private float moveForce = 5f;
        #endregion
        
        
        #region Custom Methods
        public void UpdateMovement(Rigidbody rb, InputController input) {
            HandleMovement(rb, input);
            HandleRotation(rb, input);
        }
        
        
        protected virtual void HandleMovement(Rigidbody rb, InputController input) {
            rb.AddForce(input.Vertical * moveForce * Vector3.forward, ForceMode.Force);
        }


        protected virtual void HandleRotation(Rigidbody rb, InputController input) {
            rb.AddTorque(input.Horizontal * torqueForce * Vector3.up, ForceMode.Force);
        }
        #endregion
    }
}
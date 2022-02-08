using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [RequireComponent(typeof(Rigidbody))]
    public class RigidbodyController : MonoBehaviour {
        #region Variables
        protected Rigidbody rb;
        #endregion


        
        #region Builtin Methods

        public virtual void Start() {
            rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate() {
            if (rb) HandlePhysics();
        }

        #endregion

        

        #region Custom Methods
        
        protected virtual void HandlePhysics() {
            
        }

        #endregion
    }
}
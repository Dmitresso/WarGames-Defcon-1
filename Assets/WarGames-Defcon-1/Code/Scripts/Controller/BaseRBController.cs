using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [RequireComponent(typeof(Rigidbody))]
    public class BaseRBController : MonoBehaviour {
        #region Variables
        [SerializeField] private Transform com;
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
        protected virtual void HandlePhysics() { }
        #endregion
    }
}
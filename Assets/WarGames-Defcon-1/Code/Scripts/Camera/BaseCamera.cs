using UnityEngine;
using UnityEngine.Events;


namespace WarGames_Defcon_1.Code.Scripts.Camera {
    [RequireComponent(typeof(UnityEngine.Camera))]
    public class BaseCamera : MonoBehaviour {
        #region Fields
        protected Rigidbody rb;
        protected Transform lookAtTarget;
        
        protected Vector3 targetPosition;
        protected Vector3 refVelocity;
        protected Vector3 targetFlatForward;
        protected UnityEvent updateEvent = new();
        #endregion



        #region Builtin Methods
        private void FixedUpdate() {
            CalculateFlatForward();
            updateEvent?.Invoke();
        }
        #endregion



        #region Custom Methods
        private void CalculateFlatForward() {
            targetFlatForward = rb.transform.forward;
            targetFlatForward.y = 0f;
            targetFlatForward = targetFlatForward.normalized;
        }
        
        
        protected void SwitchBehavior(UnityAction behavior) {
            updateEvent.RemoveAllListeners();
            updateEvent.AddListener(behavior);
        }


        protected void SwitchTarget(Unit.Unit unit) {
            rb = unit.RB;
            lookAtTarget = unit.transform;
        }
        #endregion
    }
}
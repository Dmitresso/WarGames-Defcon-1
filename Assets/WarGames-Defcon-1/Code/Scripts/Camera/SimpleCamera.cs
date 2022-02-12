using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Camera {
    public class SimpleCamera : BaseCamera, ICamera {
        #region Variables
        public float height = 2f;
        public float distance = 2f;
        public float smoothSpeed = 0.3f;
        #endregion
        
        
        
        #region Builtin Methods
        private void OnEnable() {
            updateEvent.AddListener(UpdateCamera);
        }


        private void OnDisable() {
            updateEvent.RemoveListener(UpdateCamera);
        }
        #endregion
        
        
        
        #region Interface Methods
        public void UpdateCamera() {
            var transform = this.transform;
            var rbPosition = rb.position;
            
            targetPosition = rbPosition + -targetFlatForward * distance + Vector3.up * height;

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref refVelocity, smoothSpeed);
            transform.LookAt(lookAtTarget);
        }
        #endregion
    }
}
using System;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Camera {
    public class SimpleCamera : BaseCamera, ICamera {
        #region Fields
        [SerializeField, Range(minHeight, maxHeight)] private float height = minHeight;
        [SerializeField] private float distance = 2f;

        [SerializeField] private float smoothSpeed = 0.3f;
        [SerializeField] private float circleSpeed = 0.1f;
        #endregion


        
        #region Constants
        private const float minHeight = 0.8f;
        private const float maxHeight = 5f;
        #endregion
        
        

        #region Properties
        private float Height {
            get => height;
            set {
                height = value switch {
                    < minHeight => minHeight,
                    > maxHeight => maxHeight,
                    _ => value
                };
            }
        }
        #endregion
        
        
        
        #region Builtin Methods
        protected void OnEnable() {
            updateEvent.AddListener(Follow);
        }


        protected void OnDisable() {
            updateEvent.RemoveListener(Follow);
        }
        #endregion
        
        
        
        #region Interface Methods
        public void Follow() {
            var transform = this.transform;
            var rbPosition = rb.position;
            
            targetPosition = rbPosition + -targetFlatForward * distance + Vector3.up * Height;

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref refVelocity, smoothSpeed);
            transform.LookAt(lookAtTarget);
        }


        public void Circle() {
            var transform = this.transform;
            var rbPosition = rb.position;
            
            targetPosition = rbPosition + -targetFlatForward * distance + Vector3.up * height;
            
            transform.LookAt(rbPosition);
            transform.RotateAround(rbPosition, lookAtTarget.transform.up, circleSpeed * Time.fixedTime);
            
        }


        public void SwitchFollowDistance() {
            switch (height) {
                case minHeight:
                    Height = maxHeight;
                    break;
                case maxHeight:
                    height = minHeight;
                    break;
            }
        }
        #endregion
    }
}
﻿using UnityEngine;
using UnityEngine.Events;


namespace WarGames_Defcon_1.Code.Scripts.Camera {
    public class BaseCamera : MonoBehaviour {
        #region Variables
        public Rigidbody rb;
        public Transform lookAtTarget;
        
        protected Vector3 targetPosition;
        protected Vector3 refVelocity;
        protected Vector3 targetFlatForward;
        protected UnityEvent updateEvent = new();
        #endregion



        #region Builtin Methods
        private void FixedUpdate() {
            if (!rb) return;
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
        #endregion
    }
}
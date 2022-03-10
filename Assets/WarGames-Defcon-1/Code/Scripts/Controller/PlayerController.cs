using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using WarGames_Defcon_1.Code.Scripts.Input;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Animator))]
    public class PlayerController : InputController {
        #region Fields
        [SerializeField] private List<Unit.Unit> units;

        private Rigidbody rb;
        private Transform transform;
        private float moveForce;
        private float torqueForce;

        private Unit.Unit currentUnit;
        private int currentUnitIndex;

        
        private Animator animator;
        #endregion



        #region Properties
        private Unit.Unit CurrentUnit {
            get => units[currentUnitIndex];
            set => currentUnit = value;
        }
        #endregion
        
        

        #region Builtin Methods
        protected void Awake() {
            base.Awake();
            animator = GetComponent<Animator>();
        }


        private void Start() {
            CurrentUnit = units[0];
            ApplyUnitParams(CurrentUnit);
            Debug.Log("[PlayerController] currentUnit.name: " + currentUnit.name);            
        }
        #endregion



        #region Custom Methods
        protected override IEnumerator Move(Vector2 direction) {
            while (moveHeld) {
                var finalDirection = direction.y * transform.forward;
                var force = rb.mass * moveForce * finalDirection;
                rb.AddForce(force, ForceMode.Force);
                yield return new WaitForFixedUpdate();
            }
        }


        protected override IEnumerator Rotate(Vector2 direction) {
            while (rotateHeld) {
                var force = rb.mass * torqueForce * direction.x * transform.up;
                rb.AddTorque(force, ForceMode.Force);
                yield return new WaitForFixedUpdate();
            }
        }


        protected override IEnumerator MainAttack() {
            while (mainAttackHeld) {
                Debug.Log("[PlayerController] MainAttack");
                yield return new WaitForSeconds(mainAttackDelay);
            }
        }


        protected override IEnumerator AlternateAttack() {
            while (alternateAttackHeld) {
                Debug.Log("[PlayerController] AlternateAttack");
                yield return new WaitForSeconds(AlternateAttackDelay);
            }
        }


        protected override void OnChangeUnit(InputAction.CallbackContext context) {
            currentUnitIndex++;
            if (currentUnitIndex == units.Count) currentUnitIndex = 0;
            var nextUnit = units[currentUnitIndex];
            if (nextUnit.Playable) CurrentUnit = nextUnit;
            ApplyUnitParams(CurrentUnit);
            Debug.Log("[PlayerController] Current unit: " + currentUnit.name);
        }

        
        protected override void OnChangeView(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnChangeView");
        }

        
        protected override void OnCommandMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnCommandMenu");
        }

        
        protected override void OnPauseMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnPauseMenu");
        }

        
        protected override void OnSettingsMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnSettingsMenu");
        }

        
        private void ApplyUnitParams(Unit.Unit unit) {
            rb = unit.RB;
            transform = unit.transform;
            moveForce = unit.MoveSpeed;
            torqueForce = unit.RotationSpeed;
            mainAttackDelay = unit.WeaponController.MainWeapon.FireRate;
            alternateAttackDelay = unit.WeaponController.AltWeapon.FireRate;
        }
        #endregion
    }
}
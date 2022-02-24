using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using WarGames_Defcon_1.Code.Scripts.Input;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Rigidbody),
                     typeof(Animator))]
    public class PlayerController : InputController {
        #region Fields
        [SerializeField] private Transform com;
        [SerializeField] private List<Unit.Unit> units;
        
        
        private Unit.Unit currentUnit;
        private int currentUnitIndex;

        
        private Rigidbody rb;
        private MovementController movement;
        private Animator animator;
        #endregion



        #region Properties
        public Unit.Unit CurrentUnit {
            get => units[currentUnitIndex];
            private set => currentUnit = value;
        }
        #endregion
        
        

        #region Builtin Methods
        protected void Awake() {
            base.Awake();
            rb = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();

            CurrentUnit = units[0];
            Debug.Log("[PlayerController] currentUnit.name: " + currentUnit.name);
        }
        #endregion



        #region Custom Methods
        protected override void HandleMainAttackPerform() {
            mainAttackHeld = true;
            StartCoroutine(nameof(MainAttackHold));
        }
        

        protected override void ChangePosition() {

        }
        
        
        


        protected override void OnMove(InputAction.CallbackContext context) {
            var moveDirection = new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
            Debug.Log("moveDirection: " + moveDirection);
            rb.AddForce(moveDirection * 30f, ForceMode.Force);
        }

        protected override void OnRotate(InputAction.CallbackContext context) {
            Debug.Log("x: " + context.ReadValue<Vector2>().x);
            rb.AddTorque(context.ReadValue<Vector2>().x * 30f * Vector3.up, ForceMode.Force);
        }
        
        
        protected override void OnChangeUnit(InputAction.CallbackContext context) {
            currentUnitIndex++;
            if (currentUnitIndex == units.Count) currentUnitIndex = 0;
            var nextUnit = units[currentUnitIndex];
            if (nextUnit.Playable) CurrentUnit = nextUnit;
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
        #endregion
    }
}
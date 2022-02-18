using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [RequireComponent(typeof(Animator),
                     typeof(InputController))]
    public class PlayerController : BaseRBController {
        #region Variables

        private Unit.Unit currentUnit;
        private int currentUnitIndex;
        [SerializeField] private List<Unit.Unit> units;
        
        
        private InputController input;
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
        protected override void Awake() {
            base.Awake();
            animator = GetComponent<Animator>();
            input = GetComponent<InputController>();
            movement = GetComponent<MovementController>();

            CurrentUnit = units[0];
            Debug.Log("[PlayerController] currentUnit.name: " + currentUnit.name);
        }
        #endregion



        #region Custom Methods
        protected override void HandleLogics() {
        }
        
        
        protected override void HandlePhysics() {
            
        }


        protected virtual void OnMove(InputAction.CallbackContext context) {
            
        }


        protected virtual void OnRotate() {
            
        }

        
        protected virtual void OnFireMain(InputAction.CallbackContext context) {
            
        }


        protected virtual void OnFireAlternate() {
            
        }


        protected virtual void OnChangeView() {
            
        }

        
        protected virtual void OnChangeUnit() {
            
        }

        
        protected virtual void OnCommandMenu() {
            
        }

        
        protected virtual void OnPauseMenu() {
            
        }

        
        protected virtual void OnSettingsMenu() {
            
        }

        
        protected virtual void HandleSwitchingNextUnit(InputController input) {
            //if (!input.NextUnitButton) return;
            //currentUnitIndex++;
            //if (currentUnitIndex == units.Count) currentUnitIndex = 0;
            //CurrentUnit = units[currentUnitIndex];
        }


        protected virtual void HandleExit(InputController input) {
            
        }
        #endregion
    }
}
using System.Collections.Generic;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [RequireComponent(typeof(InputController))]
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
        protected override void Start() {
            base.Start();
            input = GetComponent<InputController>();
            movement = GetComponent<MovementController>();
            animator = GetComponent<Animator>();
        }
        #endregion



        #region Custom Methods
        protected override void HandleLogics() {
            HandleAnimations(animator);
            HandleSwitchingNextUnit(input);
        }
        
        
        protected override void HandlePhysics() {
            HandleMovements();
            HandleWeapons();
        }


        protected virtual void HandleMovements() {
            movement.UpdateMovement(rb, input);
        }


        protected virtual void HandleWeapons() {
            currentUnit.UpdateWeapon(input);
        }


        protected virtual void HandleAnimations(Animator animator) {
            currentUnit.UpdateAnimation(animator);
        }


        protected virtual void HandleSwitchingNextUnit(InputController input) {
            if (!input.NextUnitButton) return;
            currentUnitIndex++;
            if (currentUnitIndex == units.Count) currentUnitIndex = 0;
            currentUnit = units[currentUnitIndex];
            Debug.Log("Current unit: " + currentUnit);
        }
        #endregion
    }
}
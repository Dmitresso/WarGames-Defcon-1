using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [RequireComponent(typeof(InputController))]
    public class PlayerController : BaseRBController {
        #region Variables
        private float hp = 100;
        private float armor = 0;
        
        private InputController input;
        private MovementController movement;
        private WeaponController weapon;
        #endregion



        #region Builtin Methods
        public override void Start() {
            base.Start();
            input = GetComponent<InputController>();
            movement = GetComponent<MovementController>();
            weapon = GetComponent<WeaponController>();
        }
        #endregion



        #region Custom Methods
        protected override void HandlePhysics() {
            HandleMovements();
            HandleWeapons();
        }


        protected virtual void HandleMovements() {
            movement.UpdateMovement(rb, input);
        }


        protected virtual void HandleWeapons() {
            weapon.UpdateWeapon(input);
        }
        #endregion
    }
}
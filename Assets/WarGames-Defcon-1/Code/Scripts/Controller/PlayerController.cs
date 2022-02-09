using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Weapon;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    public class PlayerController : RBController {
        #region Variables

        private float hp = 100;
        private float armor = 0;
        
        private InputController input;
        private WeaponController weapon;

        #endregion
        
        
        #region Builtin Methods

        public override void Start() {
            base.Start();
            input = GetComponent<InputController>();
            weapon = GetComponent<WeaponController>();
        }

        #endregion



        #region Custom Methods

        protected override void HandlePhysics() {
            if (!input) return;
        }

        #endregion
    }
}
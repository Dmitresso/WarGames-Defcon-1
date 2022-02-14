using System.Linq;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    public class WeaponController : MonoBehaviour {
        #region Variables
        public bool fireAllowed = true;

        private IWeapon mainWeapon;
        private IWeapon altWeapon;
        #endregion



        #region Builtin Methods
        private void Awake() {
            var w = GetComponentsInChildren<IWeapon>().ToList();
            // to fix
            mainWeapon = w[0];
            altWeapon = w[1];
            Debug.Log("[WeaponController] Weapon: " + w[0]);
            Debug.Log("[WeaponController] Weapon: " + w[1]);
        }
        #endregion



        #region Custom Methods
        public void UpdateWeapon(InputController input) {
            if (!fireAllowed) return;
            if (input.MainAttackButton) mainWeapon.WeaponFire();
            if (input.AltAttackButton) altWeapon.WeaponFire();
        }
        #endregion
    }
}
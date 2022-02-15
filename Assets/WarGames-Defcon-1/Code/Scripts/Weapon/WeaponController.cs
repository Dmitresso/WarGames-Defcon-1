using System.Linq;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    public class WeaponController : MonoBehaviour {
        #region Variables
        public bool fireAllowed = true;

        [SerializeField] private GameObject mainWeapon;
        [SerializeField] private GameObject altWeapon;
        private IWeapon mainIWeapon;
        private IWeapon altIWeapon;
        #endregion



        #region Builtin Methods
        protected void Awake() {
            mainIWeapon = mainWeapon.GetComponent<IWeapon>();
            altIWeapon = altWeapon.GetComponent<IWeapon>();
        }


        protected void OnValidate() {
            if (mainWeapon.GetComponent<IWeapon>() == null) mainWeapon = null;
            if (altWeapon.GetComponent<IWeapon>() == null) altWeapon = null;
            
        }
        #endregion



        #region Custom Methods
        public void UpdateWeapon(InputController input) {
            if (!fireAllowed) return;
            if (input.MainAttackButton) mainIWeapon.WeaponFire();
            if (input.AltAttackButton) altIWeapon.WeaponFire();
        }
        #endregion
    }
}
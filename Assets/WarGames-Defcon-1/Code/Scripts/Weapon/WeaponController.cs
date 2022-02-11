using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Input;


namespace WarGames_Defcon_1.Code.Scripts.Weapon {
    public class WeaponController : MonoBehaviour {
        #region Variables
        [Header("Weapon Controller Properties")]
        public bool fireAllowed = true;

        private List<IWeapon> weapons = new();
        #endregion



        #region Builtin Methods
        private void Start() {
            weapons = GetComponentsInChildren<IWeapon>().ToList();
        }
        #endregion



        #region Custom Methods
        public void UpdateWeapon(InputController input) {
            //if (!input.FireButton || !fireAllowed) return;
            //if (weapons.Count <= 0) return;
            //foreach (var weapon in weapons) weapon.FireWeapon();
        }
        #endregion
    }
}
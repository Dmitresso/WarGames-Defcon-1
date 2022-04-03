using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Unit {
    public abstract class Unit : BaseUnit {
        #region FIELDS
        protected Rigidbody rb;
        [SerializeField] private Transform com;
        [SerializeField] protected float armor = 0f;

        [SerializeField] protected float moveSpeed = 10f;
        [SerializeField] protected float rotationSpeed = 10f;
        #endregion



        #region PROPERTIES
        public Rigidbody RB => rb;
        
        public bool Playable => playable;
        public float MoveSpeed => moveSpeed;
        public float RotationSpeed => rotationSpeed;
        #endregion



        #region CUSTOM METHODS
        public virtual void UpdateAnimation(Animator animator) {
            
        }


        // public virtual void UpdateWeapon(InputController input) {
        //     weapon.UpdateWeapon(input);
        // }
        #endregion
    }
}
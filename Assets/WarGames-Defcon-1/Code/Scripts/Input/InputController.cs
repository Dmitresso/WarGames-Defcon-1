using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public abstract class InputController : MonoBehaviour {
        #region Fields
        [SerializeField] protected bool oneAttackHeld = true;
        [SerializeField, Range(minDelay, maxDelay)] protected float mainAttackDelay = 1f;
        [SerializeField, Range(minDelay, maxDelay)] protected float alternateAttackDelay = 1f;


        
        protected bool mainAttackHeld;
        protected bool alternateAttackHeld;
        protected bool moveHeld;
        protected bool rotateHeld;

        #endregion



        #region Constants
        private const float minDelay = 0.1f;
        private const float maxDelay = 1.5f;
        

        #endregion
        

        
        #region Properties
        public float MainAttackDelay {
            get => mainAttackDelay;
            set {
                value = value switch {
                    < minDelay => minDelay,
                    > maxDelay => maxDelay,
                    _ => value
                };
            }
        }

        public float AlternateAttackDelay {
            get => alternateAttackDelay;
            set {
                value = value switch {
                    < minDelay => minDelay,
                    > maxDelay => maxDelay,
                    _ => value
                };
            }
        }
        
        public Input Input { get; private set; }
        #endregion

        

        #region Builtin Methods
        protected void Awake() {
            Input = new Input();

            Input.Player.Move.performed += OnMovePerform;
            Input.Player.Move.canceled += context => OnMoveCancel();

            Input.Player.Rotate.performed += OnRotatePerform;
            Input.Player.Rotate.canceled += context => OnRotateCancel();
            
            Input.Player.MainAttack.performed += context => OnMainAttackPerform();
            Input.Player.MainAttack.canceled += context => OnMainAttackCancel();
            
            Input.Player.AlternateAttack.performed += context => OnAlternateAttackPerform();
            Input.Player.AlternateAttack.canceled += context => OnAlternateAttackCancel();
            
            Input.Player.ChangeUnit.performed += OnChangeUnit;
            Input.Player.ChangeView.performed += OnChangeView;
            Input.Player.CommandMenu.performed += OnCommandMenu;
            Input.Player.PauseMenu.performed += OnPauseMenu;
            Input.Player.SettingsMenu.performed += OnSettingsMenu;
        }

        
        private void OnEnable() {
            Input.Enable();
        }

        
        private void OnDisable() {
            StopAllCoroutines();
            Input.Disable();
        }
        #endregion



        #region Custom Methods
        protected virtual void OnMovePerform(InputAction.CallbackContext context) {
            moveHeld = true;
        }


        protected virtual void OnMoveCancel() {
            moveHeld = false;
        }


        protected virtual IEnumerator Move() {
            yield return new WaitWhileUnit();
        }
        
        
        protected virtual void OnRotatePerform(InputAction.CallbackContext context) {

        }
        
        
        protected virtual void OnRotateCancel() {

        }
        
        
        protected virtual void OnMainAttackPerform() {
            Debug.Log("[InputController] HandleMainAttackPerform()");
            mainAttackHeld = true;
            if (oneAttackHeld) alternateAttackHeld = false;
            StartCoroutine(nameof(MainAttack));
        }
        
        
        protected virtual void OnMainAttackCancel() {
            Debug.Log("[InputController] HandleMainAttackCancel()");
            if (mainAttackHeld) mainAttackHeld = false;
        }
        
        
        protected virtual IEnumerator MainAttack() {
            while (mainAttackHeld) {
                Debug.Log("[InputController] MainAttack()");
                yield return new WaitForSeconds(mainAttackDelay);
            }
        }

        
        protected virtual void OnAlternateAttackPerform() {
            Debug.Log("[InputController] HandleAlternateAttackPerform()");
            alternateAttackHeld = true;
            if (oneAttackHeld) mainAttackHeld = false;
            StartCoroutine(nameof(AlternateAttack));
        }

        protected virtual void OnAlternateAttackCancel() {
            Debug.Log("[InputController] HandleAlternateAttackCancel()");
            if (alternateAttackHeld) alternateAttackHeld = false;
        }
        
        
        protected virtual IEnumerator AlternateAttack() {
            while (alternateAttackHeld) {
                Debug.Log("[InputController] AlternateAttack()");
                yield return new WaitForSeconds(alternateAttackDelay);
            }
        }


        protected virtual void OnMainAttack(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnFireMain");
        }
        

        
        protected virtual void OnChangeUnit(InputAction.CallbackContext context) {

        }

        
        protected virtual void OnChangeView(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnChangeView");
        }

        
        protected virtual void OnCommandMenu(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnCommandMenu");
        }

        
        protected virtual void OnPauseMenu(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnPauseMenu");
        }

        
        protected virtual void OnSettingsMenu(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnSettingsMenu");
        }
        #endregion
    }
}
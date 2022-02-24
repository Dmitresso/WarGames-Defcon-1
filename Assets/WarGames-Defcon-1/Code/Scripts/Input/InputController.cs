using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public abstract class InputController : MonoBehaviour {
        #region Fields

        protected float mainAttackDelay = 1f;
        protected float alternateAttackDelay = 1f;
        protected bool mainAttackHeld;
        protected bool alternateAttackHeld;
        #endregion



        #region Properties
        public float MainAttackDelay => mainAttackDelay;
        public float AlternateAttackDelay => alternateAttackDelay;
        
        public Input Input { get; private set; }
        #endregion

        

        #region Builtin Methods
        protected void Awake() {
            Input = new Input();

            Input.Player.MainAttack.performed += context => HandleMainAttackPerform();
            Input.Player.MainAttack.canceled += context => HandleMainAttackCancel();

            var interaction = Input.Player.MainAttack.interactions[0];
            
            
            
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
            Input.Disable();
        }
        #endregion



        #region Custom Methods

        public int i = 0;
        protected virtual void HandleMainAttackPerform() {
            Debug.Log("[InputController] HandleMainAttackPerform()");
            mainAttackHeld = true;
            StartCoroutine(nameof(MainAttackHold));
        }
        
        
        protected void HandleMainAttackCancel() {
            Debug.Log("[InputController] HandleMainAttackCancel()");
            if (mainAttackHeld) mainAttackHeld = false;
        }
        
        
        protected virtual IEnumerator MainAttackHold() {
            i++;
            while (mainAttackHeld) {
                Debug.Log("[InputController] MainAttackHold()");
                Debug.Log("[InputController] i: " + i);
                yield return new WaitForSeconds(mainAttackDelay);
            }
        }

        
        
        
        
        
        
        protected virtual IEnumerator AlternateAttackHold(InputAction.CallbackContext context) {
            yield return new WaitForSeconds(alternateAttackDelay);
        }
        
        
        protected virtual void ChangePosition() {
            
        }
        

        protected virtual void OnMove(InputAction.CallbackContext context) {
            
        }

        
        protected virtual void OnRotate(InputAction.CallbackContext context) {

        }


        protected virtual void OnMainAttack(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnFireMain");
        }

        
        protected virtual void OnAlternateAttack(InputAction.CallbackContext context) {
            Debug.Log("[InputController] OnFireAlternate");
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
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using WarGames_Defcon_1.Code.Scripts.Camera;
using WarGames_Defcon_1.Code.Scripts.Input;
using WarGames_Defcon_1.Code.Scripts.Unit;
using WarGames_Defcon_1.Code.Scripts.Utils;


namespace WarGames_Defcon_1.Code.Scripts.Controller {
    [DefaultExecutionOrder(-50)]
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerController : BaseInput {
        #region Fields
        public Action<Vehicle> onUnitChanged;
        private SimpleCamera camera;

        private List<Vehicle> vehicles;
        private int currentUnitIndex;
        private Rigidbody rb;
        private Transform transform;
        private float moveForce;
        private float torqueForce;
        #endregion



        #region PROPERTIES
        public List<Vehicle> Vehicles {
            set {
                vehicles = value;
                InitUnits(vehicles);
            }
        }
        private Vehicle CurrentUnit { get; set; }
        #endregion
        
        

        #region BUILTIN METHODS
        protected void Awake() {
            base.Awake();
            onUnitChanged += SwitchUnit;
            
            camera = GameObject.FindGameObjectWithTag(Tags.GM.CameraController).GetComponent<CameraController>().PlayerCamera;
        }


        protected void OnEnable() {
            base.OnEnable();
        }


        protected void OnValidate() {
            base.OnValidate();
        }
        
        
        protected void Start() {
            base.Start();
        }
        #endregion



        #region CUSTOM METHODS
        protected override IEnumerator Move(Vector2 direction) {
            while (moveHeld) {
                var finalDirection = direction.y * transform.forward;
                var force = rb.mass * moveForce * finalDirection;
                rb.AddForce(force, ForceMode.Force);
                yield return new WaitForFixedUpdate();
            }
        }


        protected override IEnumerator Rotate(Vector2 direction) {
            while (rotateHeld) {
                var force = rb.mass * torqueForce * direction.x * transform.up;
                rb.AddTorque(force, ForceMode.Force);
                yield return new WaitForFixedUpdate();
            }
        }


        protected override IEnumerator MainAttack() {
            while (mainAttackHeld) {
                Debug.Log("[PlayerController] MainAttack");
                yield return new WaitForSeconds(mainAttackDelay);
            }
        }


        protected override IEnumerator AlternateAttack() {
            while (alternateAttackHeld) {
                Debug.Log("[PlayerController] AlternateAttack");
                yield return new WaitForSeconds(AlternateAttackDelay);
            }
        }


        protected override void OnChangeUnit(InputAction.CallbackContext context) {
            onUnitChanged?.Invoke(CurrentUnit);
        }

        
        protected override void OnChangeView(InputAction.CallbackContext context) {
            camera.SwitchFollowDistance();
        }

        
        protected override void OnCommandMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnCommandMenu");
        }

        
        protected override void OnCommandCenterMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnCommandCenterMenu");
        }


        protected override void OnSettingsMenu(InputAction.CallbackContext context) {
            Debug.Log("[PlayerController] OnSettingsMenu");
        }


        protected override void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) {
            if (scene.name == scenesData.mainMenu.name) SwitchActionMap(ActionMap.UI);
        }


        // protected override void OnClickPerform(InputAction.CallbackContext context) { }


        private void InitUnits(List<Vehicle> vehicles) {
            if (vehicles.Count <= 0) {
                Debug.LogError("[PlayerController] \"units\" list is empty.");
                return;
            }
            
            for (var i = 0; i < vehicles.Capacity - 1; i++) {
                if (vehicles[i] != null) {
                    currentUnitIndex = i;
                    CurrentUnit = vehicles[i];
                    ApplyVehicleParams(CurrentUnit);
                    Debug.Log("[PlayerController] currentUnit.name: " + CurrentUnit.name);
                    break;
                }
                if (i == vehicles.Capacity - 1 && CurrentUnit == null) Debug.LogError("[PlayerController] \"units\" list doesn't contain any Unit.");
            }
        }
        
        
        private void SwitchUnit(Vehicle unit) {
            if (vehicles.Count <= 1) return;
            currentUnitIndex++;
            if (currentUnitIndex == vehicles.Capacity) currentUnitIndex = 0;
                
            var nextUnit = vehicles[currentUnitIndex];
            if (nextUnit != null && nextUnit.Playable) CurrentUnit = nextUnit;
            ApplyVehicleParams(unit);
        }


        private void ApplyVehicleParams(Vehicle unit) {
            rb = unit.RB;
            transform = unit.transform;
            moveForce = unit.MoveSpeed;
            torqueForce = unit.RotationSpeed;
            mainAttackDelay = unit.WeaponController.MainWeapon.FireRate;
            alternateAttackDelay = unit.WeaponController.AltWeapon.FireRate;
        }
        #endregion
    }
}
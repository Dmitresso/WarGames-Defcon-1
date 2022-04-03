using System.Collections.Generic;
using UnityEngine;
using WarGames_Defcon_1.Code.Scripts.Unit;


namespace WarGames_Defcon_1.Code.Scripts.Level {
    public class Objective : MonoBehaviour {
        #region FIELDS
        [SerializeField] private ObjectiveType objectiveType;
        [SerializeField] private bool done;
        [SerializeField] private Vector3 place;
        [SerializeField] private List<Building> buildings;
        [SerializeField] private List<Vehicle> vehicles;
        [SerializeField] private List<Soldier> troops;
        #endregion


        
        #region BUILTIN METHODS
        private void OnValidate() {
            switch (objectiveType) {
                case ObjectiveType.Delivery:
                    SwitchObjectiveType(ObjectiveType.Delivery);
                    break;
                case ObjectiveType.Destroy:
                    SwitchObjectiveType(ObjectiveType.Destroy);
                    break;
            }
        }
        #endregion



        #region CUSTOM METHODS
        public void SwitchObjectiveType(ObjectiveType type) {
            switch (type) {
                case ObjectiveType.Delivery:
                    objectiveType = ObjectiveType.Delivery;
                    break;
                case ObjectiveType.Destroy:
                    objectiveType = ObjectiveType.Destroy;
                    break;
            }
        }
        #endregion
    }
}
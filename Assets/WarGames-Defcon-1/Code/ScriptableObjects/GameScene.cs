using UnityEditor;
using UnityEngine;


namespace WarGames_Defcon_1.Code.ScriptableObjects {
    [CreateAssetMenu(fileName = "New Level Scene", menuName = "ScriptableObjects/GameScene", order = 2)]
    public class GameScene : ScriptableObject {
        public SceneAsset levelScene;
        public string description;
    }
}
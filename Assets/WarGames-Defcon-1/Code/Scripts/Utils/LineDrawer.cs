using UnityEditor;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Utils {
    public class LineDrawer : MonoBehaviour {
        private Vector3 p1, p2;
        private LineRenderer line; 
        
        
        private void Awake() {
            p1 = p2 = Vector3.zero;

            gameObject.AddComponent<LineRenderer>();
            line = GetComponent<LineRenderer>();
            line.startColor = line.endColor = Color.red;
            line.widthCurve = AnimationCurve.Constant(1f, 1f, 1f);
            line.sharedMaterial = AssetDatabase.GetBuiltinExtraResource<Material>("Default-Line.mat");
            line.positionCount = 2;
        }

        public void Draw(Vector3 p1, Vector3 p2) {
            line.SetPositions(new []{ p1, p2 });
        }
    }
}
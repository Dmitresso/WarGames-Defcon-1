using UnityEditor;


namespace WarGames_Defcon_1.Code.Scripts.Input.Editor {
    [CustomEditor(typeof(KeyboardInput))]
    public class KeyboardInputEditor : UnityEditor.Editor {
        #region Variables
        private KeyboardInput targetInput;
        #endregion



        #region Builtin Methods
        private void OnEnable() {
            targetInput = (KeyboardInput) target;
        }


        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            DrawDebugUI();
            Repaint();
        }
        #endregion

        

        #region Custom Methods
        private void DrawDebugUI() {
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            EditorGUILayout.Space();
            EditorGUI.indentLevel++;
            EditorGUILayout.LabelField("H: " + targetInput.Horizontal);
            EditorGUILayout.LabelField("V: " + targetInput.Vertical);
            EditorGUI.indentLevel--;
            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
        }
        #endregion
    }
}
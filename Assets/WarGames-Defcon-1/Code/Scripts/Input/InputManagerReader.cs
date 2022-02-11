using UnityEditor;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Input {
    public static class InputManagerReader {
        public static void Read() {
            var inputManager = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0];

            var obj = new SerializedObject(inputManager);
            var axisArray = obj.FindProperty("m_Axes");

            if (axisArray.arraySize == 0) Debug.Log("No Axes");

            for (var i = 0; i < axisArray.arraySize; ++i) {
                var axis = axisArray.GetArrayElementAtIndex(i);

                var name = axis.FindPropertyRelative("m_Name").stringValue;
                var axisVal = axis.FindPropertyRelative("axis").intValue;
                var inputType = (InputType)axis.FindPropertyRelative("type").intValue;

                Debug.Log(name);
                Debug.Log(axisVal);
                Debug.Log(inputType);
            }
        }
    }
}
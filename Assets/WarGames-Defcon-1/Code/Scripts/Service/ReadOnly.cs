﻿using Unity.Collections;
using UnityEditor;
using UnityEngine;


namespace WarGames_Defcon_1.Code.Scripts.Service {
    #if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnly : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label) {
            string valueStr;
        
            switch (prop.propertyType) {
                case SerializedPropertyType.Integer:
                    valueStr = prop.intValue.ToString();
                    break;
                case SerializedPropertyType.Boolean:
                    valueStr = prop.boolValue.ToString();
                    break;
                case SerializedPropertyType.Float:
                    valueStr = prop.floatValue.ToString("0.00000");
                    break;
                case SerializedPropertyType.String:
                    valueStr = prop.stringValue;
                    break;
                default:
                    valueStr = "(not supported)";
                    break;
            }
        
            EditorGUI.LabelField(position,label.text, valueStr);
        }
    }
    #endif
}
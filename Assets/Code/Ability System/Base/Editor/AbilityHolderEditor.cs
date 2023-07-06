using UnityEngine;
using UnityEditor;

namespace carlmzamora.AbilitySystem.EditorCustomizer
{
    [CustomEditor(typeof(AbilityHolder))]
    public class AbilityHolderEditor : Editor
    {
        private SerializedProperty abilityProperty;
        private SerializedProperty useMouseButtonProperty;
        private SerializedProperty keyToPressProperty;
        private SerializedProperty mouseButtonIntProperty;

        private string selectedMouseButtonIntName;
        private string[] mouseButtonIntNames =
            { "Mouse0", "Mouse1", "Mouse2"};

        private void OnEnable()
        {
            abilityProperty = serializedObject.FindProperty("ability");
            useMouseButtonProperty = serializedObject.FindProperty("useMouseButton");
            keyToPressProperty = serializedObject.FindProperty("keyToPress");
            mouseButtonIntProperty = serializedObject.FindProperty("mouseButtonInt");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            int selectedIndex;

            //display normally
            EditorGUILayout.PropertyField(abilityProperty);
            EditorGUILayout.PropertyField(useMouseButtonProperty);

            if (!useMouseButtonProperty.boolValue)
            {
                //display normally
                EditorGUILayout.PropertyField(keyToPressProperty);
            }
            else
            {
                EditorGUI.BeginChangeCheck();

                //display as popup insted of field, then get index
                selectedIndex = EditorGUILayout.Popup("Mouse Button Ints (0-2)", GetSelectedIndex(), mouseButtonIntNames);

                if (EditorGUI.EndChangeCheck())
                {
                    //upon change, set int value of property in script to selected index
                    mouseButtonIntProperty.intValue = selectedIndex;
                }
            }

            serializedObject.ApplyModifiedProperties();
        }

        int GetSelectedIndex()
        {
            return mouseButtonIntProperty.intValue;
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEditor;

namespace TMW
{
    [CustomEditor(typeof(Hexagon))]
    public class HexagonEditor : Editor
    {
        public override bool HasPreviewGUI()
        {
            return true;
        }

        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
            base.OnPreviewGUI(r, background);
            Hexagon hexagon = (Hexagon)target;
            EditorGUILayout.LabelField(string.Format("Type:  {0}", hexagon.Type.ToString()));
            EditorGUILayout.LabelField(string.Format("IsPassable:  {0}", hexagon.IsPassable));
            EditorGUILayout.LabelField(string.Format("Coordinate:  {0}, {1}", hexagon.Coordinate.x, hexagon.Coordinate.x));
        }
    }
}
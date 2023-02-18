using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CustomEditor(typeof(MapGenerator))]
public class MapGenEditor : Editor {
    public override void OnInspectorGUI() {
        MapGenerator mapGen = (MapGenerator)target;

        if(DrawDefaultInspector()) {
            if(mapGen.autoUpdate) {
                mapGen.GenerateMap();
            }
        }

        if (GUILayout.Button("Generate Map")) {
            mapGen.GenerateMap();
        }
        
    }

}

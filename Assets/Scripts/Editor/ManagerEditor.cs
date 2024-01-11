using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Managers))]
public class ManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Managers myTarget = (Managers)target;

        myTarget.obj = (GameObject)EditorGUILayout.ObjectField(myTarget.obj, typeof(GameObject), true);
    
        
        if(GUILayout.Button("Create Object"))
        {
            myTarget.CreateObject();
        }
    }
}

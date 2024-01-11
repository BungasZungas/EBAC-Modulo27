using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ToolbarExample : Editor
{
    [MenuItem("Zungas/Spawn Object")]
    public static void SpawnObject()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.position = Vector3.zero;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public GameObject obj;

    public void CreateObject()
    {
        var a = Instantiate(obj);
        a.transform.position = Vector3.zero;
    }
}

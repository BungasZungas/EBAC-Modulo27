using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListScript : MonoBehaviour
{
    public List<string> list;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
            Debug.Log(list.GetRandom());
    }
}

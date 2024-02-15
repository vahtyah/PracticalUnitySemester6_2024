using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPractical6 : MonoBehaviour
{
    public GameObject blackObject;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            blackObject.GetComponent<Rigidbody>().AddForce(0, 200, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2Practical6 : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
    
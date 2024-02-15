using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3Practical6 : MonoBehaviour
{
    Renderer rd;
    private void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        rd.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        rd.material.color = Color.blue;
    }
}

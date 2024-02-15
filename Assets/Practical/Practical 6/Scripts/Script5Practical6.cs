using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5Practical6 : MonoBehaviour
{
    Vector3 mouseOffSet;
    float mouseZCoord;

    private void OnMouseDown()
    {
        mouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mouseOffSet = gameObject.transform.position - GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + mouseOffSet;
    }
}

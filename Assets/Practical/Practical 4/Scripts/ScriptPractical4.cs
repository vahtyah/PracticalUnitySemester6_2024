using UnityEngine;

public class ScriptPractical4 : MonoBehaviour
{
    private Vector3 originalPos;

    private void Start()
    {
        originalPos = transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        transform.position = originalPos;
    }
}
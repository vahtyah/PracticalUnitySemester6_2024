using System;
using System.Collections;
using UnityEngine;

namespace Practical.Practical_7.Scripts
{
    public class IEDestroyAfterForSeconds : MonoBehaviour
    {
        [SerializeField] private float seconds;
        private IEnumerator Start()
        {
            yield return new WaitForSeconds(seconds);
            Destroy(gameObject);
        }
    }
}
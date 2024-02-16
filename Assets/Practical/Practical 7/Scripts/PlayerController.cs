using System;
using UnityEngine;

namespace Practical.Practical_7.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Transform pointShoot;
        [SerializeField] private ParticleSystem muzzlesEffect;
        [SerializeField] private GameObject bulletPrefab;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                muzzlesEffect.Play();
                Instantiate(bulletPrefab, pointShoot.position, Quaternion.LookRotation(pointShoot.forward));
            }
        }
        
    }
    
}
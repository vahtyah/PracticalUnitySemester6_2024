﻿using System;
using System.Collections;
using UnityEngine;

namespace Practical.Practical_7.Scripts
{
    public class BulletController : MonoBehaviour
    {
        [SerializeField] private GameObject impactBullet;
        private void Update() { transform.Translate(Vector3.forward * (100f * Time.deltaTime)); }

        private void OnTriggerEnter(Collider other)
        {
            Instantiate(impactBullet, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
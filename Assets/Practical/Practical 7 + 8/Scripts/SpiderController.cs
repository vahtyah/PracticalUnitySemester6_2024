using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Experimental.GlobalIllumination;

namespace Practical.Practical_7.Scripts
{
    public class SpiderController : MonoBehaviour
    {
        [SerializeField] private float health;
        [SerializeField] private Transform player;
        private float currentHealth;
        public Action<float> onChangeHealth;

        private NavMeshAgent navMesh;

        private void Start()
        {
            currentHealth = health;
            navMesh = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            // if (Input.GetKeyDown(KeyCode.S))
            {
                navMesh.SetDestination(player.position);
            }
        }

        public void ChangeHealth(float value)
        {
            currentHealth = Mathf.Clamp(currentHealth + value, 0, health);
            Debug.Log(currentHealth);
            onChangeHealth.Invoke(currentHealth / health);
        }
    }
}
using System;
using Practical.Practical_7.Scripts.State;
using UnityEngine;
using UnityEngine.AI;

namespace Practical.Practical_7.Scripts
{
    public class SpiderController : MonoBehaviour
    {
        [SerializeField] private float health;
        [SerializeField] private Transform player;
        private float currentHealth;
        public Action<float> onChangeHealth;
        private Animator anim;
        private NavMeshAgent navMesh;
        private bool isDie;

        private StateComponent State;

        private void Start()
        {
            currentHealth = health;
            navMesh = GetComponent<NavMeshAgent>();
            anim = GetComponent<Animator>();
            State = new StateComponent(this);
        }

        private void Update()
        {
            State.Update();
        }

        public bool CanAttack()
        {
            return navMesh.remainingDistance <= navMesh.stoppingDistance;
        }

        public void ChangeHealth(float value)
        {
            currentHealth = Mathf.Clamp(currentHealth + value, 0, health);
            if (currentHealth <= 0 && !isDie)
                isDie = true;
            onChangeHealth?.Invoke(currentHealth / health);
        }

        public void PlayAnim(string animName) { anim.Play(animName); }

        public NavMeshAgent GetNavMesh => navMesh;
        public Transform PlayerTransform => player;
        public bool IsDie => isDie;
    }
}
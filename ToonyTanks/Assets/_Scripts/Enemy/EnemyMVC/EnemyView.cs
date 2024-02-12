using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class EnemyView : MonoBehaviour
    {
        private EnemyController enemyController;
        private float rotation;
        private float movement;

        public Rigidbody rigidbody;

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        public void SetEnemyController(EnemyController _enemyController)
        {
            enemyController = _enemyController;
        }

        public Rigidbody GetRigidbody()
        {
            return rigidbody;
        }


    }
}
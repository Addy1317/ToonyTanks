using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class EnemyModel : MonoBehaviour
    {
        private EnemyController enemyController;

        public float movementSpeed;
        public float rotationSpeed;
        
        public EnemyModel(float _movement, float _rotation)
        {
            movementSpeed = _movement;
            rotationSpeed = _rotation;
        }

        public void SetEnemyController(EnemyController _enemyController)
        {
            enemyController = _enemyController;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class EnemyController : MonoBehaviour
    {

        private EnemyView enemyView;
        private EnemyModel enemyModel;
        private Rigidbody rb;

        public EnemyController(EnemyModel _enemyModel, EnemyView _enemyView)
        {
            enemyModel = _enemyModel;
            enemyView = _enemyView;


        }


    }
}
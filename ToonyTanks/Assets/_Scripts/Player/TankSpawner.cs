using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class TankSpawner : MonoBehaviour
    {
        [SerializeField] private TankView tankView;

        void Start()
        {
            SpawnTank();
        }

        private void SpawnTank()
        {
            TankModel tankModel = new TankModel(30, 30);
            TankController tankController = new TankController(tankModel, tankView);
        }
    }
}
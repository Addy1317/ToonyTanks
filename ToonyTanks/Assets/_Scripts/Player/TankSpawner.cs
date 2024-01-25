using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class TankSpawner : MonoBehaviour
    {
        [SerializeField] private TankView tankView;
        // Start is called before the first frame update
        void Start()
        {
            SpawnTank();
        }

        private void SpawnTank()
        {
            TankModel tankModel = new TankModel();
            TankController tankController = new TankController(tankModel, tankView);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class TankSelection : MonoBehaviour
    {
        public TankSpawner tankSpawner;
        
        public void GreenTankSelected()
        {
            tankSpawner.SpawnTank(TankTypes.GreenTank);
            this.gameObject.SetActive(false);
        }
        public void BlueTankSelected()
        {
            tankSpawner.SpawnTank(TankTypes.BlueTank);
            this.gameObject.SetActive(false);
        }
        public void RedTankSelected()
        {
            tankSpawner.SpawnTank(TankTypes.RedTank);
            this.gameObject.SetActive(false);
        }
    }
}
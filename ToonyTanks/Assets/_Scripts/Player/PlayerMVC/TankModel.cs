using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class TankModel
    {
        private TankController tankController;

        public TankModel()
        {

        }

        public void SetTankController(TankController _tankController)
        {
            tankController = _tankController;
        }

    }
}

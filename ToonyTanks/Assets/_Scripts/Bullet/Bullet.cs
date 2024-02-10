using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class Bullet : MonoBehaviour
    {
        public TankShooting tankShooting;

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("its Colliding to : " + gameObject.name);
            tankShooting.ReturnBulletToPool(gameObject);
        }
    }
}
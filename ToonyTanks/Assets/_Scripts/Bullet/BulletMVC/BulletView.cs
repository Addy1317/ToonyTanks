using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class BulletView : MonoBehaviour
    {
        [SerializeField] private int playerNumber = 1;
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private Transform fireTransform;
        [SerializeField] private float minLaunchForce = 1;
        [SerializeField] private float maxLaunchForce = 30f;
        [SerializeField] private float MaxChargeTime = 0.75f;
        [SerializeField] private string fireButton;
        [SerializeField] private float currentLaunchForce;
        [SerializeField] private float chargeSpeed;
        [SerializeField] private bool Fired;

        private void OnEnable()
        {
            currentLaunchForce = minLaunchForce;

        }

        private void Start()
        {
            fireButton = "Fire" + playerNumber;
            chargeSpeed = (maxLaunchForce - minLaunchForce) / MaxChargeTime;
        }



    }
}
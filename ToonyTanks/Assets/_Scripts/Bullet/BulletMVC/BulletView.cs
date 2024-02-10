using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class BulletView : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private int playerNumber = 1;
        [SerializeField] private Rigidbody shell;
        [SerializeField] private GameObject shellObject;

        [SerializeField] private GameObject buletShell;
        [SerializeField] private Transform fireTransform;

        [Header("Force Properties")]
        [SerializeField] private float minLaunchForce = 15;
        [SerializeField] private float maxLaunchForce = 30f;
        [SerializeField] private float MaxChargeTime = 0.75f;

        private string fireButton;
        private float currentLaunchForce;
        private float chargeSpeed;
        private bool Fired;

        private void OnEnable()
        {
            currentLaunchForce = minLaunchForce;
        }

        private void Start()
        {
            fireButton = "Fire" + playerNumber;
            chargeSpeed = (maxLaunchForce - minLaunchForce) / MaxChargeTime;
        }

        private void Update()
        {
            LaunchBullet();
        }

        private void LaunchBullet()
        {
            if (currentLaunchForce >= maxLaunchForce && !Fired)
            {
                currentLaunchForce = maxLaunchForce;
                FireBullet();
            }
            else if (Input.GetButtonDown(fireButton))
            {
                Fired = false;
                currentLaunchForce = minLaunchForce;
            }
            else if (Input.GetButton(fireButton) && !Fired)
            {
                currentLaunchForce += chargeSpeed * Time.deltaTime;
            }
            else if (Input.GetButtonUp(fireButton) && !Fired)
            {
                FireBullet();
            }
        }

        private void FireBullet()
        {
            Fired = true;
            Rigidbody shellInstance = Instantiate(shell, fireTransform.position, fireTransform.rotation);
            shellInstance.velocity = currentLaunchForce * fireTransform.forward;
            currentLaunchForce = minLaunchForce;
        }

    }
}
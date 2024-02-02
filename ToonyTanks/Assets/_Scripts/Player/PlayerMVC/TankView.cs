using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class TankView : MonoBehaviour
    {
        private TankController tankController;
        private float rotation;
        private float movement;

        public Rigidbody rb;
        public MeshRenderer[] tankMeshChilds;

        private void Start()
        {
            GameObject cam = GameObject.Find("Main Camera");
            cam.transform.SetParent(transform);
            cam.transform.position = new Vector3(0f, 3f, -4f);
        }

        private void Update()
        {
            MovementInputs();
            TankMovementChecks();          
        }

        public void SetTankController(TankController _tankController)
        {
            tankController = _tankController;
        }

        public Rigidbody GetRigidbody()
        {
            return rb;
        }

        private void MovementInputs()
        {
            movement = Input.GetAxis("Vertical");
            rotation = Input.GetAxis("Horizontal");
        }

        private void TankMovementChecks()
        {
            if (movement != 0)
            {
                tankController.Move(movement, tankController.GetTankModel().movementSpeed);
            }

            if (rotation != 0)
            {
                tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
            }
        }

        public void ChangeColor(Material color)
        {
            for (int i = 0; i < tankMeshChilds.Length; i++)
            {
                tankMeshChilds[i].material = color;
            }
        }
    }
}
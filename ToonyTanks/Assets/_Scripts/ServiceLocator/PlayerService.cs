using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class PlayerService : MonoBehaviour
    {
        public static PlayerService Instance { get { return Instance; } }

        private static PlayerService instance;

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this.gameObject);
                Debug.LogError(this + "Singleton of PlayerService is Trying to Crerate Second Instance");
            }
        }
    }
}
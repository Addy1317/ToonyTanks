using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonyTanks
{
    public class GenericMonoSingleton<T> : MonoBehaviour where T : GenericMonoSingleton<T>
    {
        private static T instance;
        public static T Instance { get { return instance; } }

        private void Awake()
        {
            if(instance == null)
            {
                instance = (T)null;
            }
            else
            {
                Destroy(this.gameObject);
                Debug.LogError("Singleton of" + (T)this + "is Trying to create Second Instance");
            }
        }
    }
}
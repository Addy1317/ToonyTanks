using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

namespace ToonyTanks
{
    public class LobbyManager : MonoBehaviour
    {
        [Header("Buttons")]
        [SerializeField] private Button playButton;
        [SerializeField] private Button optionButton;
        [SerializeField] private Button quitButton;

        private void Start()
        {
        }

        private void Update()
        {

        }

        public void PlayButton()
        {
            SceneManager.LoadScene(1);
        }

        public void OptionButton()
        {
            Debug.Log("Options are open");
        }

        public void BackButton()
        {

        }

        public void QuitButton()
        {
            Application.Quit();
        }


    }
}
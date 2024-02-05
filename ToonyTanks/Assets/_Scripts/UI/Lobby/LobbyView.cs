using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

namespace ToonyTanks
{
    public class LobbyView : MonoBehaviour
    {
        [Header("HeaderText")]
        [SerializeField] private TextMeshPro headerText;

        [Header("LobbyButtons")]
        [SerializeField] private Button playButton;
        [SerializeField] private Button optionButton;
        [SerializeField] private Button quitButton;

        private LobbyController lobbyController;

        public void SetLobbyController(LobbyController _lobbyController)
        {
            lobbyController = _lobbyController;
            lobbyController.PlayButtonController();
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        public void PlayButton()
        {
            //Debug.Log("PlayButton through Lobby View");
            lobbyController.PlayButtonController();
        }
        
    }
}
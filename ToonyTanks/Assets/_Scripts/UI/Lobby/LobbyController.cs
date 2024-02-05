using UnityEngine;
using UnityEngine.SceneManagement;

namespace ToonyTanks
{
    public class LobbyController
    {
        private LobbyView lobbyView;

        public LobbyController(LobbyView _lobbyView)
        {

        }

        public void PlayButtonController()
        {
            Debug.Log("Play");
            //SceneManager.LoadScene(1);
        }

        public void OptionButton()
        {
            Debug.Log("Options are working");
        }

        public void BackButton()
        {
            Debug.Log("Back in progress");
        }

        public void QuitButton()
        {
            Application.Quit();
            Debug.Log("Application is Quitting");
        }
    }
}
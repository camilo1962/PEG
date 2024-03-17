using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace pegGame {
    /*
     Clase de controlador que controla la carga de la escena.
     */
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame ( int boardType )
        {
            SceneManager.LoadScene("Game");
            Constants.selectedBoard = boardType;
        }
        public void QuitGame ( )
        {
            Application.Quit();
        }
        public void IrAOtra(string name)
        {
            SceneManager.LoadScene(name);

        }
    }
}

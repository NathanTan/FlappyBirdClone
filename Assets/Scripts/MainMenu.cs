using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

namespace FlappyBird
{
    
    public class MainMenu : MonoBehaviour
    {
        public Text highScore;

        private void Start() {
            this.highScore.text = "High Score: " + PlayerPrefs.GetInt(Constants.HighScore).ToString();
        }

        public void StartGame() {
            Debug.Log("Starting Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace FlappyBird {
    public class GameManager : MonoBehaviour
    {
        public int playerScore;

        public Text textScore;

        public Text highScore;

        public GameObject gameOverScreen;

        public Difficulty difficulty = Difficulty.Normal;

        private void Start()
        {
            this.highScore.text = "High Score: " + PlayerPrefs.GetInt(Constants.HighScore).ToString();
            this.difficulty = GlobalControl.Instance.difficulty;
            Debug.Log("Difficulty: " + this.difficulty);
        }

        // Context Menu to allow you to manually run the function in Unity
        [ContextMenu("Increase Score")]
        public void addScore(int scoreToAdd) {
            playerScore += scoreToAdd; // TODO: add gold pipe for more points???
            textScore.text = playerScore.ToString();
            this.highScore.text = "High Score: " + PlayerPrefs.GetInt(Constants.HighScore).ToString();
        }

        public void restartGame() {
            // Load the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void gameOver() {
            updateHighScore(this.playerScore);

            // Make the game over UI appeare.
            gameOverScreen.SetActive(true);
        }

        public Difficulty getDifficulty()
        {
            return Difficulty.Normal;
        }

        public void SetDifficulty(int index) {
            if (index == 0) {
                Debug.Log("Easy Mode");
                this.difficulty = Difficulty.Easy;
            } else if (index == 1) {
                Debug.Log("Normal Mode");
                this.difficulty = Difficulty.Normal;
            } else if (index == 2) {
                Debug.Log("Hard Mode");
                this.difficulty = Difficulty.Hard;
            }
        }

        private void updateHighScore(int score)
        {
            int highScore = PlayerPrefs.GetInt(Constants.HighScore);
            if (score > highScore)
                PlayerPrefs.SetInt(Constants.HighScore, score);
        }
    }

}
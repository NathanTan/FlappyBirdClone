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

        public GameObject gameOverScreen;

        public Difficulty difficulty = Difficulty.Normal;

        // Context Menu to allow you to manually run the function in Unity
        [ContextMenu("Increase Score")]
        public void addScore(int scoreToAdd) {
            playerScore += scoreToAdd; // TODO: add gold pipe for more points???
            textScore.text = playerScore.ToString();
        }

        public void restartGame() {
            // Load the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void gameOver() {
            // Make the game over UI appeare.
            gameOverScreen.SetActive(true);
        }

        public Difficulty getDifficulty()
        {
            return Difficulty.Normal;
        }
    }

}
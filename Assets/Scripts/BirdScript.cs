using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{

    public class BirdScript : MonoBehaviour
    {

        // Reference the ridged body
        public Rigidbody2D myRigidbody;

        public float flapStrength;

        public GameManager manager;

        public bool birdIsAlive = true;

        public Difficulty difficulty;

        // Start is called before the first frame update
        void Start()
        {
            manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameManager>();
            gameObject.name = "Mr. Birdie";
            difficulty = GlobalControl.Instance.difficulty;
            Debug.Log("Difficulty: " + difficulty);
        }

        // Update is called once per frame
        void Update()
        {
            bool tryJump = (Input.GetKeyDown(KeyCode.Space) || touchScreenJump()) && (birdIsAlive || difficulty == Difficulty.Easy);

            // Jump on the space bar
            // Allow the bird to jump on easy mode
            if (tryJump)
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (this.difficulty != Difficulty.Easy) {
                endGame();
            } else if (this.difficulty == Difficulty.Easy && collision.gameObject.CompareTag("AllDeath")) {
                // If easy mode, only end the game for the AllDeath zones, the floor and back wall
                endGame();
            }
        }

        public void enableBird(bool isAlive)
        {
            this.birdIsAlive = isAlive;
        }

        private bool touchScreenJump()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    return true;
                }
            }
            return false;
        }

        private void endGame() {
            manager.gameOver();
            enableBird(false);
        }

    }
}
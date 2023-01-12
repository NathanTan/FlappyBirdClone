using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{

    public class PipeMiddleScript : MonoBehaviour
    {
        public GameManager manager;
        private int birdLayer = 3;

        // Start is called before the first frame update
        void Start()
        {
            // Since the pipes are prefabs and don't exists when the game starts,
            // the trick is to add a reference to the game manager once the pipe
            // prefab spawns in, based on the tag.
            // Then using GetComponent, we can get the object we want from the list of
            // 1 item with the logic tag.
            manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameManager>();
            Debug.Log(manager);
            Debug.Log("manager above");
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {

            // Just to be safe, put the bird on it's own layer and check that layer only.
            if (collision.gameObject.layer == birdLayer)
            {
                manager.addScore(1);
            }
        }
    }

}
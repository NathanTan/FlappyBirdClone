using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{

    public class PipeScript : MonoBehaviour
    {
        public float moveSpeed = 2;
        public float deadZone = -178;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(gameObject.name);
        }

        // Update is called once per frame
        void Update()
        {
            // * by time to adjust for frame rate
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                Debug.Log(transform.position.x + " < " + deadZone);

                // "gameObject" must exist under MonoBehvaiour is my guess
                Destroy(gameObject);
            }
        }
    }

}
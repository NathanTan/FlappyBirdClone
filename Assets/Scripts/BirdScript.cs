using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Reference the ridged body
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameManager>();
        gameObject.name = "Mr. Birdie";
    }

    // Update is called once per frame
    void Update()
    {
        // Jump on the space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        manager.gameOver();
    }
}

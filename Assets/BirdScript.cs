using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // Reference the ridged body
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Mr. Birdie";
        Debug.Log(gameObject.name);
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
}

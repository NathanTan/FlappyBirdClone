using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1.5f;
    private float timer = 0;
    private float heightOffset = 10;

    // Start is called before the first frame update
    private void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer < spawnRate) {
            timer+= Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
        
    }

    private void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        // Spawn the pipes, at the postion, with the current rotation
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint)), transform.rotation);
    }
}

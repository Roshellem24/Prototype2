using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float topBound = 30;
    private float lowerBound = -10;
    float leftBound = -45;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

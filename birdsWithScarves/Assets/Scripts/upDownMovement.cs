using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDownMovement : MonoBehaviour
{
    //vars for up down movement
    private bool dirUp = true;
    public float speed = 2.0f;

    public float yMax = 0.07f;
    public float yMin = -0.07f;

    void Update()
    {
        //move
        if (dirUp)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        //change direction
        if (transform.position.y >= yMax)
        {
            dirUp = false;
        }

        if (transform.position.y <= yMin)
        {
            dirUp = true;
        }
    }
}

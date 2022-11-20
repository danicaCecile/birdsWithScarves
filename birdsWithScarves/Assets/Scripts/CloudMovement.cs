using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float startingX = 0f;
    public float endingX = 1f;

    void Update()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        if (transform.position.x >= endingX)
        {
            transform.position = new Vector3(startingX, transform.position.y, transform.position.z);
        }
    }
}

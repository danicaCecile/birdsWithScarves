using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);

        }
    }
}

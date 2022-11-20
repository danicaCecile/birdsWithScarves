using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public Animator playerAnimator;

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            playerAnimator.SetBool("isWalking", true);
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            playerAnimator.SetBool("isWalking", true);
            transform.localScale = new Vector3(-1, 1, 1);

        }
        else
        {
            playerAnimator.SetBool("isWalking", false);
        }

        /*float h = Input.GetAxis("Horizontal");
       float v = Input.GetAxis("Vertical");

       Vector3 tempVect = new Vector3(h, v, 0);
       tempVect = tempVect.normalized * speed * Time.deltaTime;
       rb.MovePosition(rb.transform.position + tempVect);*/
    }
}

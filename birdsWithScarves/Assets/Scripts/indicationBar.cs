using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicationBar : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public GameObject player;

    private float playerX;
    public GameObject current;
    private bool isNearby = false;

    void Update()
    {
        playerX = player.transform.position.x;
        
        if(playerX >= xMin && playerX <= xMax)
        {
            current.SetActive(true);
            isNearby = true;
        }
        else
        {
            current.SetActive(false);
            isNearby = false;
        }
        Debug.Log(isNearby);
    }

    public bool getIsNearby()
    {
        return isNearby;
    }
}

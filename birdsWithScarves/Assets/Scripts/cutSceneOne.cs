using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cutSceneOne : MonoBehaviour
{
    //objects in the cutscene
    public GameObject leal;
    public GameObject mel;
    public GameObject textBubble;
    public TextMeshProUGUI text;

    //speed mel moves at
    private float moveSpeed = 1f;

    //current stage of the scene
    private int sceneStage = 0;

    void Start()
    {
    
    }

    void Update()
    {
        if(sceneStage == 0)
        {
            mel.transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            if(mel.transform.position.x <= 1.03)
            {
                sceneStage = 1;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private float wheelSpeed = 20;

    private PlayerController pcs;

    // Start is called before the first frame update
    void Start()
    {
        pcs = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pcs.gameOver == false)
        {
            transform.Rotate(new Vector3(wheelSpeed, 0f, 0f));
        }
        //transform.Rotate(new Vector3(wheelSpeed, 0f, 0f));
    }
}

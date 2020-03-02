using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAni;

    public float jumpHeight;
    //public float movementSpeed;
    public float gravityModiifer;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAni = GetComponent<Animator>();
        Physics.gravity *= gravityModiifer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            playerAni.SetTrigger("Jump_Trig");
        }
    }
}

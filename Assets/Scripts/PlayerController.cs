using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAni;

    public float movementSpeed;
    public float jumpHeight;
    //public float movementSpeed;
    public float gravityModiifer;
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        //getting the components so they will be allowed in the code
        playerRb = GetComponent<Rigidbody>();
        playerAni = GetComponent<Animator>();
        Physics.gravity *= gravityModiifer;
    }

    // Update is called once per frame
    void Update()
    {
        //allowing the space bar to used to allow the player to jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            playerAni.SetTrigger("Jump_Trig");
            isOnGround = false;
        }

        if (Input.GetKey("left"))
        {
           transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        isOnGround = true;
    }   
}

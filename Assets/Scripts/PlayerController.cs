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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            playerAni.SetTrigger("Jump_Trig");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAni;

    public float zBoundRange = 4f;
    public float movementSpeed;
    public float jumpHeight;
    public float gravityModiifer;

    public bool isOnGround = true;
    public bool gameOver = true;

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
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }

        StayInbounds();
    }

    private void OnCollisionEnter (Collision collision)
    {
        isOnGround = true;
    }

    private void StayInbounds()
    {
        if (transform.position.z < -zBoundRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBoundRange);
        }

        if (transform.position.z > zBoundRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundRange);
        }
    }

}

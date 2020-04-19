using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    private Animator playerAni;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public AudioClip runSound;
    private AudioSource playerAudio;

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
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModiifer;
    }

    // Update is called once per frame
    void Update()
    {
        //allowing the space bar to used to allow the player to jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            playerAni.SetTrigger("Jump_trig");
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }

        //playerAudio.PlayOneShot(runSound, 1.0f);
        StayInbounds();
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Street"))
        {
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAni.SetBool("Death_b", true);
            playerAni.SetInteger("DeathType_int", 1);
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }   

    private void StayInbounds()
    {
        if (transform.position.z < -4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4);
        }

        if (transform.position.z > 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1);
        }
    }

}

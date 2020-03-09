using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    [SerializeField] GameObject powerupObject;
    [SerializeField] GameObject powerupIndicator;
    private int numberOfJumps;

    private Rigidbody playerRb;
    private PlayerController playerCon;

    public bool hasPowerup;
    public bool canDoubleJump = true;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        playerCon = GetComponent<PlayerController>();

        InvokeRepeating("SpawnPowerup", 10, 35);
    }

    // Update is called once per frame
    void Update()
    {
        powerupIndicator.transform.position = transform.position + new Vector3(0,-0.5f,0);   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Powerup") && hasPowerup)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canDoubleJump)
            {
                float jumpVelocity = 100f;
                playerRb.velocity = Vector3.up * jumpVelocity;
            }

            else
            {
                float jumpVelocity = 100f;
                playerRb.velocity = Vector3.up * jumpVelocity;
                canDoubleJump = false;
            }


            Debug.Log("Player has collected the " + collision.gameObject + " and enabled the double jump!");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {


            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupTimer());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupTimer()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    void SpawnPowerup()
    {
        Vector3 spawnPos = new Vector3(-6.72f, 3.25f, -1.44f);
        Instantiate(powerupObject, spawnPos, powerupObject.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoveRight : MonoBehaviour
{

    public float speed = 10;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Next Level"))
        {

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 camPos = new Vector3(-1, 6.4f, -8.3f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + camPos;
    }
}

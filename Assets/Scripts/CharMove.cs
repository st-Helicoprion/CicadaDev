using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("A"))
        {
            playerRB.velocity += Vector3.forward*.5f;
        }
        if (Input.GetButtonDown("A"))
        {
            playerRB.velocity += Vector3.forward * .5f;
        }
    }
}

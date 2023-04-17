using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public Rigidbody playerRB;
    public Transform playerCam;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            playerRB.velocity = playerCam.forward* speed;
            

        }
        this.gameObject.transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal"),0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_PlayerMove : MonoBehaviour
{
    public float DefaultSpeed = 1;
    public float BoostSpeed;
    public float RotateSpeed = 1;
    public Transform CameraPosition;

    // Update is called once per frame
    void Update()
    {
        float MoveSpeed=DefaultSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed = BoostSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (CameraPosition.position - transform.position) * Time.deltaTime * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (CameraPosition.position - transform.position) * -1 * Time.deltaTime * MoveSpeed;
            // transform.position+=Vector3.back*Time.deltaTime*MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * RotateSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * RotateSpeed, Space.World);
        }
        Debug.Log(MoveSpeed);
    }
}

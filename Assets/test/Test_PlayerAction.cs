using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_PlayerAction : MonoBehaviour
{
    public float DefaultSpeed = 1;
    public float BoostSpeed;
    public float RotateSpeed = 1;
    public Transform CameraPosition;
    public GameObject prefab;
    Test_SonarBehavior test_SonarBehavior;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        if (Input.GetMouseButtonDown(0))
        {
            test_SonarBehavior = prefab.GetComponent<Test_SonarBehavior>();
            Instantiate(prefab, CameraPosition.position - new Vector3(0,test_SonarBehavior.SonarScale+1,0), Quaternion.identity);
        }
    }
    void PlayerMove()
    {
        float MoveSpeed = DefaultSpeed;
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
    }
}

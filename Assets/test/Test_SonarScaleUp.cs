using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SonarScaleUp : MonoBehaviour
{
    public GameObject prefab;
    public Transform point;
    Test_SonarBehavior test_SonarBehavior;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            test_SonarBehavior = prefab.GetComponent<Test_SonarBehavior>();
            Instantiate(prefab, transform.position - new Vector3(0, test_SonarBehavior.SonarScale, 0), Quaternion.identity);
        }
    }

}

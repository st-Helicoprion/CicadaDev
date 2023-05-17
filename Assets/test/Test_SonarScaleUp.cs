using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_SonarScaleUp : MonoBehaviour
{
    public GameObject prefab;
    public Transform point;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(prefab,point.position,Quaternion.identity);
        }
    }
    
}

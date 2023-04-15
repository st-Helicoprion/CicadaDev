using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarSkill : MonoBehaviour
{
    public GameObject prefab;
    public Transform container;
    public float frequency;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (frequency <= 0)
        {
            frequency = 0;
        }
        else frequency -= 0.5f*Time.deltaTime;
    
        if(Input.GetMouseButtonDown(0))
        {
            
            Instantiate(prefab, container);
            frequency += 0.5f;
          
        }
    }
}

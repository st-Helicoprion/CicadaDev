using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoBehavior : MonoBehaviour
{
    public float RFreq;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SonarBehavior sonarBehavior;
        float curFreq;

        sonarBehavior = other.GetComponent<SonarBehavior>();
        curFreq = sonarBehavior.curFreq;
        Debug.Log("hit, frequency is"+curFreq);
    }
}

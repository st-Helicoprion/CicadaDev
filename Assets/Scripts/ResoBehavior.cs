using JetBrains.Annotations;
using Newtonsoft.Json.Converters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResoBehavior : MonoBehaviour
{
    public enum FreqRange { high, medium, low};
    public FreqRange setFreq;
    public GameObject prefab;
    public Animator anim;
    public bool blip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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


        if (setFreq == FreqRange.high)
        {
            if(curFreq>=20f)
            {
                SetInteractable();
            }
        }
        else if (setFreq == FreqRange.medium)
        {
            if (curFreq>=10f)
            {
                SetInteractable();
            }
        }
        else if (setFreq == FreqRange.low)
        {
            if (curFreq >= 5f)
            {
                SetInteractable();
            }
        }


    }

    void SetInteractable()
    {
        if(transform.gameObject.CompareTag("Light"))
        {
            anim.CrossFade("Glow", 0f);
           
        }

        if(transform.gameObject.CompareTag("Door"))
        {
            anim.CrossFade("Open", 0f);
           
        }
    }
}

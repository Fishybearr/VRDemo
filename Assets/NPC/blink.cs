using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour{

    [SerializeField]
     int blinkAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("MakeBlink");
        InvokeRepeating("CallBlinkEnum", .1f, 2);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, blinkAmount);
    }

    void CallBlinkEnum() 
    {
        StartCoroutine("MakeBlink");
    }

    IEnumerator MakeBlink() 
    {
        while(blinkAmount < 100) 
        {
            yield return new  WaitForSeconds(.001f);
            blinkAmount+= 10;
        }
        while(blinkAmount > 0) 
        {
            yield return new WaitForSeconds(.001f);
            blinkAmount-= 10;
        }
    }
}

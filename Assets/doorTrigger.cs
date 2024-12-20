using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public Animator animator;
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
        if(other.tag == "DoorHit") 
        {
            StartCoroutine("doorTimer");
        }
    }

    IEnumerator doorTimer() 
    {
        animator.SetBool("open", true);
        yield return new WaitForSeconds(4);
        animator.SetBool("open", false);
    }
}

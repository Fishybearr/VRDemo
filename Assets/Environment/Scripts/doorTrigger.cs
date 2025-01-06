using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DoorHit")
        {
            StartCoroutine("doorTimer");
        }
    }

    IEnumerator doorTimer()
    {
        animator1.SetBool("open", true);
        animator2.SetBool("open", true);
        yield return new WaitForSeconds(4);
        animator1.SetBool("open", false);
        animator2.SetBool("open", false);
    }
}

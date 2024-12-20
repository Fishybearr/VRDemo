using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DoorHit")
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

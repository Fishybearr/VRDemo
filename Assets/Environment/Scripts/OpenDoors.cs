using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    float startOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("OpenDoor", startOffset, 10);
    }

    void OpenDoor() 
    {
        StartCoroutine("doorTimer");
    }

    IEnumerator doorTimer() 
    {
        animator.SetBool("open", true);
        yield return new WaitForSeconds(4);
        animator.SetBool("open", false);
    }
}


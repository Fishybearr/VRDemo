using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class NPCIK : MonoBehaviour
{
    /*
     * --------------------------------------------------This code is based on INSERT UNITY SOURCE-----------------------------------------------------------
     */

    //TODO: refactor this
    public GameObject lookTarget;
    Animator animator;
   public bool ikActive = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (animator) 
        {
            if (ikActive)
            {

                if (lookTarget != null)
                {
                    animator.SetLookAtWeight(1,.01f,.75f); //eyes need to be handled separate as they do not have bones
                    animator.SetLookAtPosition(lookTarget.transform.position);
                }
                else
                {
                    animator.SetLookAtWeight(0,0,0);
                }
            }
        }
    }
}

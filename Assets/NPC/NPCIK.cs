using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class NPCIK : MonoBehaviour
{
    public GameObject lookTarget;
    Animator animator;
   public bool isikActive = false;
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
            if (isikActive)
            {

                if (lookTarget != null)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookTarget.transform.position);
                }
                else
                {
                    animator.SetLookAtWeight(0);
                }
            }
        }
    }
}

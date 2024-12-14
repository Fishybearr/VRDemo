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

    [SerializeField]
    float globalWeight = 1.0f;
    [SerializeField]
    float bodyWeight = .01f;
    [SerializeField]
    float headWeight = .75f;

    GameObject pivot;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        pivot = new GameObject("pivot");
        pivot.transform.parent = transform;
        pivot.transform.localPosition = new Vector3(0, 1.5f, 0); //TODO: no magic numbers
        //this transform will need to be locked somehow so that the animMovement
        //does not interfere with the looking
    }

    // Update is called once per frame
    void Update()
    {
        /*TODO: if raycast from player is not hitting her
         *  face then lerp globalWeight to 0 in update()
         *  
         *  then add some kind of tracking of this for the smile blendshape
         *  
         *  ALSO add support for idle anim transition and movement pause
         *  this will keep her in place for viewing
         *  
         *  also add distance calculation to prevent her from looking at
         *  player when too far away
         *  
         *  ALSO Set x limits on rotation for head
         */

        pivot.transform.LookAt(lookTarget.transform);
        float pivotRotY = pivot.transform.localRotation.y;
       // Debug.Log(pivotRotY);


        //TODO: make a duplicate of this system for chest rotation
        if(pivotRotY < .65f && pivotRotY > -.65f) 
        {
            globalWeight = Mathf.Lerp(globalWeight, 1, Time.deltaTime * 2.5f); //TODO: swap 2.5 with a resetFactor float
        }
        else 
        {
            globalWeight = Mathf.Lerp(globalWeight, 0, Time.deltaTime * 2.5f);
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (animator) 
        {
            if (ikActive)
            {

                if (lookTarget != null)
                {
                    animator.SetLookAtWeight(globalWeight,bodyWeight,headWeight); //eyes need to be handled separate as they do not have bones
                    animator.SetLookAtPosition(lookTarget.transform.position);
                }
                else
                {
                    //set global weight to 0
                    animator.SetLookAtWeight(0);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class NPCIK : MonoBehaviour
{
    /*
     * This script is based on Unity's demo ik implementation https://docs.unity3d.com/6000.0/Documentation/Manual/InverseKinematics.html
     */

    public GameObject lookTarget;
    Animator animator;

    public bool ikActive = true;

    public float globalWeight = 1.0f;

    public float bodyWeight = .01f;

    public float headWeight = .75f;

    public float eyeWeight = 1.0f;

    GameObject pivot;

    public Transform startTransform;

    public Slider heightSlider;

    public float animatorStartSpeed = .75f;

    public bool shouldLook = false;

    void Start()
    {
        pivot = new GameObject("pivot");

        //sets initial values of startTransform
        startTransform.position = transform.position;
        startTransform.rotation = transform.rotation;
        startTransform.localScale = transform.localScale;

        animator = GetComponent<Animator>();

        //sets up transforms for pivot obj
        pivot.transform.parent = transform; // changed from transform
        pivot.transform.localPosition = new Vector3(0, 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Manages the pivot Transform used to limit IK rotation for the character
        pivot.transform.LookAt(lookTarget.transform);
        float pivotRotY = pivot.transform.localRotation.y;

        if (pivotRotY < .65f && pivotRotY > -.65f && shouldLook)
        {
            globalWeight = Mathf.Lerp(globalWeight, 1, Time.deltaTime * 2.5f);
        }
        else
        {
            globalWeight = Mathf.Lerp(globalWeight, 0, Time.deltaTime * 2.5f);
        }
    }

    /// <summary>
    /// Sets the look weight for the character to follow player if IK is active
    /// </summary>
    private void OnAnimatorIK()
    {
        if (animator)
        {
            if (ikActive)
            {
                if (lookTarget != null)
                {
                    animator.SetLookAtWeight(globalWeight, bodyWeight, headWeight,eyeWeight); //eyes need to be handled separate as they do not have bones
                    animator.SetLookAtPosition(lookTarget.transform.position);
                }
                else
                {
                    //set global weight to 0
                    animator.SetLookAtWeight(0, 0, 0, 0);
                }
            }
        }
    }

    /// <summary>
    /// Resets the y-axis rotation of the character
    /// </summary>
    public void resetRot()
    {
        transform.rotation = startTransform.rotation;
        transform.position = new Vector3(
            transform.position.x,
            startTransform.position.y,
            transform.position.z
        );
    }

    /// <summary>
    /// Rescales character based on setting heightSlider
    /// </summary>
    public void ScaleCharacter()
    {
        //resizes character based on settings height slider
        transform.localScale = startTransform.localScale * heightSlider.value;

        //scales playback speed of character animations to match charcater scale
        animator.speed = animatorStartSpeed / heightSlider.value;
    }
}

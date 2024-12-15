using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ToggleNPCMove : MonoBehaviour
{
    public Animator animator;
    public NPCIK np;
    public Animation moveAnimation;

    // Start is called before the first frame update
    void Start()
    {
        moveAnimation = GetComponent<Animation>();
        moveAnimation.Play();
    }

    /// <summary>
    /// Swaps NPC animator and movement controller between idle and walking states
    /// </summary>
    public void ChangeAnimState()
    {
        if (animator.GetBool("IsIdle") == true)
        {
            animator.SetBool("IsIdle", false);
            moveAnimation["NPCMove"].speed = 1;
            np.resetRot();
        }
        else
        {
            moveAnimation["NPCMove"].speed = 0;
            animator.SetBool("IsIdle", true);
        }
    }
}

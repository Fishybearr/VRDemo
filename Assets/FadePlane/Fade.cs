using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Animations;
using TMPro;

public class Fade : MonoBehaviour
{
    Animator animator;
    public TMP_Dropdown dropDown;
    public GameObject player;

    [SerializeField]
    Vector3 largeScale = new Vector3(2,2,2);
    [SerializeField]
    Vector3 defaultScale = new Vector3(1,1,1);
    [SerializeField]
    Vector3 smallScale = new Vector3(.5f,.5f,.5f);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // this should be a requireComponent
        animator.SetBool("FadeIn", true); //make sure game starts faded out
    }


    //TODO: Refactor all of this

    public void ResizePlayer()
    {
        StartCoroutine("FadeInOut");
        
    }

    //TODO: try to set up delagating for this. Could be the reason it doesn't fire when teleporting
    public void TeleportFade()
    {
        StartCoroutine("TeleFade");
        Debug.Log("Faded");
    }

    public void ChangeFade() 
    {
        animator.SetBool("FadeIn",!animator.GetBool("FadeIn"));
    }

     IEnumerator FadeInOut() 
    {
        ChangeFade();
        yield return new WaitForSeconds(1);
        if (dropDown.value == 1)
        {
            //set defaultScale
            player.transform.localScale = smallScale;
        }
        else if (dropDown.value == 0)
        {
            //set small size
            player.transform.localScale = defaultScale;
        }
        else
        {
            //set big size
            player.transform.localScale = largeScale;
            //Debug.Log(dropDown.value.ToString());
        }
        ChangeFade();
    }

    IEnumerator TeleFade() 
    {
        ChangeFade();
        yield return new WaitForSeconds(1);
        ChangeFade();
    }

    
 
}

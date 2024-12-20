using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

public class Fade : MonoBehaviour
{
    Animator animator;
    public TMP_Dropdown dropDown;
    public GameObject player;

    [SerializeField]
    Vector3 largeScale = new Vector3(2, 2, 2);

    [SerializeField]
    Vector3 defaultScale = new Vector3(1, 1, 1);

    [SerializeField]
    Vector3 smallScale = new Vector3(.5f, .5f, .5f);

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("FadeIn", true); //makes sure game starts faded out
    }

    public void ResizePlayer()
    {
        StartCoroutine("FadeInOut");
    }

    public void TeleportFade()
    {
        StartCoroutine("TeleFade");
        Debug.Log("Faded");
    }

    public void ChangeFade()
    {
        animator.SetBool("FadeIn", !animator.GetBool("FadeIn"));
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

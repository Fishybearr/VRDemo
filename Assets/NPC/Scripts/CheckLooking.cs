using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckLooking : MonoBehaviour
{
    public NPCIK npc;
    public LayerMask mask;
    public int noticeDistance = 5;

    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, transform.forward, Color.red);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, noticeDistance, mask))
        {
            if (hit.transform.tag == "FaceHit")
            {
                npc.shouldLook = true;
            }
            else
            {
                npc.shouldLook = false;
            }
        }
        else
        {
            npc.shouldLook = false;
        }
    }

    public void SetNoticeDistance()
    {
        //ths int cast is okay because the slider is set to whole numbers only
        noticeDistance = (int)slider.value;
    }
}

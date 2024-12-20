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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, transform.forward, Color.red);
        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.forward,out hit,noticeDistance,mask))
        {
            if (hit.transform.tag == "FaceHit") 
            {
                //Debug.Log("FaceHit");
                npc.shouldLook = true;
            }
            else 
            {
                //Debug.Log(hit.transform.name);
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
        noticeDistance =  (int)slider.value;
    }
}

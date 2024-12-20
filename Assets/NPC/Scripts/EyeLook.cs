using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLook : MonoBehaviour
{
    public Transform lookAt;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(lookAt);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugView : MonoBehaviour
{
    public GameObject debugRay;
    public GameObject debugSphere;
    bool isActive = false;

    bool debugActive = false;

    public Slider xPos;
    public Slider yPos;
    public Slider zPos;
    public Slider scale;
    float defaultXPos;
    float defaultYPos;
    float defaultZPos;
    float defaultScale;

    Vector3 sphereDefaultScale;

    public GameObject debugMenu;

    // Start is called before the first frame update
    void Start()
    {
        sphereDefaultScale = debugSphere.transform.localScale;
        debugSphere.GetComponent<MeshRenderer>().enabled = false;
        debugRay.SetActive(false);

        debugMenu.SetActive(false);

        //set defaults
        defaultXPos = xPos.value;
        defaultYPos = yPos.value;
        defaultZPos = zPos.value;
        defaultScale = scale.value;
    }

    public void UpdateSpherePos()
    {
        debugSphere.transform.localPosition = new Vector3(xPos.value, yPos.value, zPos.value);
    }

    public void UpdateSphereScale()
    {
        debugSphere.transform.localScale = sphereDefaultScale * scale.value;
    }

    public void ToggleDebugRender()
    {
        isActive = !isActive;
        debugRay.SetActive(isActive);
        debugSphere.GetComponent<MeshRenderer>().enabled = isActive;
    }

    public void ToggleDebugSettings()
    {
        debugActive = !debugActive;
        debugMenu.SetActive(debugActive);
    }

    public void ResetSettings()
    {
        xPos.value = defaultXPos;
        yPos.value = defaultYPos;
        zPos.value = defaultZPos;
        scale.value = defaultScale;
        UpdateSphereScale();
        UpdateSpherePos();
    }
}

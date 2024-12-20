using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    //variables to control blinking
    int blinkAmount = 0;
    bool canBlink = true;

    [Tooltip("Time between blinks in seconds")]
    [SerializeField]
    int timeBetweenBlinks = 2;

    [SerializeField]
    int minBlinkTime = 1;

    [SerializeField]
    int maxBlinkTime = 4;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        //updates blink BlendShape every frame based on blinkAmount
        gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, blinkAmount);

        // runs blink Coroutines when possible
        if (canBlink)
        {
            StartCoroutine("MakeBlink");
            StartCoroutine("WaitForBlink");
        }
    }

    /// <summary>
    /// sets canBlink false,
    /// Waits random number of seconds between minBlinkTime and maxBlinkTime,
    /// then sets canBlink true
    /// </summary>
    /// <returns></returns>
    IEnumerator WaitForBlink()
    {
        canBlink = false;
        yield return new WaitForSeconds(timeBetweenBlinks);
        timeBetweenBlinks = Random.Range(minBlinkTime, maxBlinkTime); // 1 to 4 seconds between blinks
        canBlink = true;
    }

    /// <summary>
    /// increases blendshape value unitl eyes are closed,
    /// then decreases blendshape value unitl eyes are fully open
    /// </summary>
    /// <returns></returns>
    IEnumerator MakeBlink()
    {
        while (blinkAmount < 100)
        {
            yield return new WaitForSeconds(.001f);
            blinkAmount += 10;
        }
        while (blinkAmount > 0)
        {
            yield return new WaitForSeconds(.001f);
            blinkAmount -= 10;
        }
    }
}

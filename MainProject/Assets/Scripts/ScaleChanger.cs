using UnityEngine;
using System.Collections;

public class ScaleChanger : MonoBehaviour
{
    // Original scale of the GameObject
    private Vector3 originalScale;

    // Time for the scale transition
    public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Save the original scale
        originalScale = transform.localScale;
    }

    // OnEnable is called when the GameObject becomes active
    void OnEnable()
    {
        // Start the scaling coroutine
        StartCoroutine(ScaleToOriginalSize());
    }

    IEnumerator ScaleToOriginalSize()
    {
        // Scale down to half size instantly
        transform.localScale = originalScale * 0.5f;

        // Gradually scale back to original size over 'transitionTime' seconds
        float currentTime = 0f;
        while (currentTime <= transitionTime)
        {
            // Calculate the current scale
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, currentTime / transitionTime);
            // Increment the timer
            currentTime += Time.deltaTime;
            // Wait for the next frame
            yield return null;
        }

        // Ensure the scale is set to the original
        transform.localScale = originalScale;
    }
}



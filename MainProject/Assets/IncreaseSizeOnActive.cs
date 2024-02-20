using UnityEngine;
using System.Collections;


public class IncreaseSizeOnActive : MonoBehaviour
{
 
    // Factor to increase the size by (e.g., 1.5 for 50% increase)
    public float sizeIncreaseFactor = 1.5f;

    // Duration of the smooth size increase
    public float increaseDuration = 2.0f;

    // Original scale of the GameObject
    private Vector3 originalScale;

    // Awake is called when the script instance is being loaded
    void Awake()
    {
        // Save the original scale
        originalScale = transform.localScale;
    }

    // OnEnable is called when the GameObject becomes active
    void OnEnable()
    {
        // Start the smooth size increase coroutine
        StartCoroutine(SmoothIncrease());
    }

    IEnumerator SmoothIncrease()
    {
        Vector3 targetScale = originalScale * sizeIncreaseFactor;
        float elapsedTime = 0;

        while (elapsedTime < increaseDuration)
        {
            // Smoothly interpolate from the current scale to the target scale over time
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, (elapsedTime / increaseDuration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the scale is set to the target scale
        transform.localScale = targetScale;
    }
    void OnDisable()
    {
        // Reset the scale to original
        transform.localScale = originalScale;
    }
}



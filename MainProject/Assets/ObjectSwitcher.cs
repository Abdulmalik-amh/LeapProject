using UnityEngine;
using UnityEngine.UI;
public class ObjectSwitcher : MonoBehaviour
{
    // The array of objects you want to switch
    public GameObject[] objects;

    // The current index of the active object
    private int currentIndex = 0;

    // A method to switch the objects
    public void SwitchObjects()
    {
        // Deactivate the current object
        objects[currentIndex].SetActive(false);

        // Increment the index and wrap it around if it exceeds the array length
        currentIndex = (currentIndex + 1) % objects.Length;

        // Activate the next object
        objects[currentIndex].SetActive(true);
    }
}

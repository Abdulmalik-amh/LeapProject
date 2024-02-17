using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // The array of toggles for each item
    public Toggle[] itemToggles;

    // The index of the currently selected item
    private int selectedItem = -1;

    // Start is called before the first frame update
    void Start()
    {
        // Loop through the toggles and add listeners
        for (int i = 0; i < itemToggles.Length; i++)
        {
            // Get the current toggle and index
            Toggle toggle = itemToggles[i];
            int index = i;

            // Add a listener that invokes the SwitchItem method
            toggle.onValueChanged.AddListener((value) => SwitchItem(value, index));
        }
    }

    // Switch the item based on the toggle value and index
    void SwitchItem(bool value, int index)
    {
        // If the toggle is on, set the selected item to the index
        if (value)
        {
            selectedItem = index;
        }
        // If the toggle is off, and the index matches the selected item, reset the selected item
        else if (index == selectedItem)
        {
            selectedItem = -1;
        }

        // Do something with the selected item, such as activating or deactivating it
        // For example, you can use an array of game objects that correspond to the items
        // and enable or disable them based on the selected item
    }
}

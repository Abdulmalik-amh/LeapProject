using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnableItem : MonoBehaviour
{

    public GameObject [] Items;
    private int currentIndex = 0;
    


    public void ItemEnable(){

      
        // Deactivate the current object
        Items[currentIndex].SetActive(false);

        // Increment the index and wrap it around if it exceeds the array length
        currentIndex = (currentIndex + 1) % Items.Length;

        // Activate the next object
        Items[currentIndex].SetActive(true);
       
    }
}

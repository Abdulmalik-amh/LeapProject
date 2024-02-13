using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject item;
    public void EnableItem(){

        if(item.activeInHierarchy == false){
            item.SetActive(true);
        }

        else{
            item.SetActive(false);
        }
        
    }
}

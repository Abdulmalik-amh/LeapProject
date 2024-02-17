using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheElevatorScript : MonoBehaviour
{
    public Transform elvator;
    public float speed = 5f; // adjust the speed of movement
    public bool isactive;


    private void Update()
    {
        if (isactive) 
        {
            transform.position = Vector3.MoveTowards(transform.position, elvator.position, speed * Time.deltaTime); 
        }
    }
    public void Isactive()
    {

        isactive = true;
        
    }
    
    /*public void OnButtonClicked(bool value)
    {
        // Do something with the value
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }*/


}


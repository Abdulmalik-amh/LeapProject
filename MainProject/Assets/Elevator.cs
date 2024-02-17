using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Animator animator;
    public GameObject vrPlayer;

    private bool topToBottomState = true;
    private bool inMovement = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartElevator()
    {
        if (inMovement == false)
        {
            if (topToBottomState)
            {
                animator.SetTrigger("ElevatorDownToUp Trigger");
            }
            else
            {
                animator.SetTrigger("ElevatorUpToDown Trigger");
            }
            inMovement = true;
        }      
    }

    public void OnAnimationStartEvelevator()
    {
        if (topToBottomState == false)
        {

            topToBottomState = true;
            inMovement = false;

        }
    }

    public void OnAnimationEndEvelevator()
    {
        if (topToBottomState == true)
        {

            topToBottomState=false;
            inMovement=false;

        }
    }
}

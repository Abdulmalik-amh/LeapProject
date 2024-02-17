using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrab : MonoBehaviour
{

    // The distance of the raycast
    public float rayDistance = 10f;

    // The layer mask to filter the raycast
    public LayerMask rayMask;

    // The reference to the grabbed object
    private Rigidbody grabbedObject;

    // The distance between the shooter and the grabbed object
    private float grabDistance;
    public float raycastDistance = 10f;
    // The reference to the camera
    private GameObject target;
    RaycastHit hit;
    public bool isactive;

    public float RayDistancee = 5f;
    private void Start()
    {
        // Get the camera component
        
    }

    private void Update()
    {
        // Check if the user presses the left mouse button
        if (isactive)
        {
            // Shoot a raycast from the camera center
            Physics.Raycast(transform.position, -transform.up, out hit);

            hit.rigidbody.velocity = Vector3.zero;

            // Set the position of the hit object to the current position plus an offset
            hit.rigidbody.position = transform.position + -transform.up * RayDistancee;

        }
        else
        {
            Isdisabled();
        }
       
    }
    public void Isactive()
    {

        isactive = true;

    }
    public void Isdisabled()
    {

        isactive = false;

    }
}

      



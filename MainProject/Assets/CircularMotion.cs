using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    // The center point of the circle
    public Vector3 center;

    // The radius of the circle
    public float radius;

    // The angular speed of the object
    public float speed;

    // The current angle of the object
    private float angle;

    // Update is called once per frame
    void Update()
    {
        circular();
       
        
    }
    void circular()
    {
        // Increment the angle by the angular speed times the time delta
        angle += speed * Time.deltaTime;

        // Calculate the x and y coordinates of the object using trigonometry
        float x = center.x + radius * Mathf.Cos(angle);
        float z = center.z + radius * Mathf.Sin(angle);

        // Set the position of the object to the calculated coordinates
        transform.position = new Vector3(x, center.y, z);
    }
}

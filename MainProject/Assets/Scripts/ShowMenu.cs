using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ShowMenu : MonoBehaviour
{
    public float distance = 3f;
    public Transform pointA;
    public GameObject MainMenu;
    public InputActionProperty showButton;
    // Start is called before the first frame update
   

    // Update is called once per frame

    private void Update()
    {
        if (showButton.action.WasPressedThisFrame())
            {
            MainMenu.SetActive(!MainMenu.activeSelf);
            MainMenu.transform.position = pointA.position + new Vector3(pointA.forward.x, 0, pointA.forward.z).normalized * distance ;

        }
        MainMenu.transform.LookAt(new Vector3(pointA.position.x, MainMenu.transform.position.y , pointA.position.x));
        MainMenu.transform.forward *= -1;

    }

}

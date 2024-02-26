using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class GrabDetection : MonoBehaviour
{
    private XRBaseInteractor interactor;
    public Image image;

    void Start()
    {
        interactor = GetComponent<XRBaseInteractor>();
    }

    void Update()
    {
        if (interactor.selectTarget != null)
        {
            image.enabled = true;
        
            
        }
        else{
            image.enabled = false;
        }
    }
}
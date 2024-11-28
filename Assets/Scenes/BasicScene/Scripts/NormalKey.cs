using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class NormalKey : MonoBehaviour
{
    [SerializeField]
    private GameObject openable;

    [SerializeField]
    private GameObject unlockOnUse;
    // Start is called before the first frame update
    void Start()
    {
        openable.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        openable.GetComponent<XRGrabInteractable>().enabled = false;
        unlockOnUse.GetComponent<XRGrabInteractable>().enabled = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == openable)
        {
            Destroy(gameObject);
            openable.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            openable.GetComponent<XRGrabInteractable>().enabled = true;
            unlockOnUse.GetComponent<XRGrabInteractable>().enabled = true;
 
        }
    }
}

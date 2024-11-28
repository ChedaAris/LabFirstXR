using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class MagneticTerminal : MonoBehaviour
{
    [SerializeField]
    private GameObject key;

    [SerializeField]
    private GameObject door;


    private void Start()
    {
        door.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        door.GetComponent<XRGrabInteractable>().enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(key))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            door.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            door.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}

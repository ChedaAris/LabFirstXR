using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muic : MonoBehaviour
{
    public void OnAction()
    {
        GetComponent<AudioSource>().Play();
    }
}

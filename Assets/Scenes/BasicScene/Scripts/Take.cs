using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    /// <summary>
    /// Chiamato quando una capsula viene presa in gioco.
    /// Aumenta lo score e distrugge l'oggetto.
    /// </summary>
    public void WhenObjectTaken()
    {
        Destroy(gameObject);
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score++;
    }
}

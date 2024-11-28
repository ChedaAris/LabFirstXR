using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    
    void Start()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }

    /// <summary>
    /// Rende visibile per un breve periodo di tempo il canvas.
    /// </summary>
    public void OnPCPressed()
    {
        canvas.GetComponent<Canvas>().enabled = true;
        StartCoroutine(DisableCanvas());
    }

    /// <summary>
    /// Nasconde il canvas dopo 20 secondi.
    /// </summary>
    /// <returns></returns>
    private IEnumerator DisableCanvas()
    {
        yield return new WaitForSeconds(20f);
        canvas.GetComponent<Canvas>().enabled = false;
    }
}

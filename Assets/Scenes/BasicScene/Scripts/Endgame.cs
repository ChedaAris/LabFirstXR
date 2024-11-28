using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("SaveManager").GetComponent<SaveManager>().Save();
        SceneManager.LoadScene("Menu");
    }
}

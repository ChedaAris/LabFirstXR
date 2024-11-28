using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI txtScore;

    private int _score;

    public int Score
    {
        get { return _score; }
        set { 
            _score = value;
            //Aggiorna lo score ogni volta che viene cambiato
            txtScore.text = $"Pills: {Score}";
        }
    }

    /// <summary>
    /// All'inizio della scena imposta un valore di default
    /// </summary>
    void Start()
    {
        txtScore.text = $"Pills: {Score}";
    }

}

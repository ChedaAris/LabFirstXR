using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO.Pipes;

public class SaveManager : MonoBehaviour
{

    [Serializable]
    public class SaveData
    {
        public int score;
        public DateTime date;
        public Vector3 ballPosition;
    }


    private static string path;
    int bestScore;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.persistentDataPath + "/saves.json";
    }

    public void Save()
    {
        LoadSaves();
        int score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().Score;
        //Salva solo lo score migliore
        if (score <= bestScore)
        {
            return;
        }

        SaveData data = new SaveData();
        data.score = score;
        data.date = DateTime.Now;
        data.ballPosition = GameObject.Find("Ball").transform.position;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);
    }

    public void LoadSaves()
    {
        string json = File.ReadAllText(path);

        SaveData data = new SaveData();
        data = JsonUtility.FromJson<SaveData>(json);

        bestScore = data.score;
    }

}

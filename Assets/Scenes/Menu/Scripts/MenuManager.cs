using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SaveManager;

public class MenuManager : MonoBehaviour
{
    private static string path;

    [SerializeField]
    private TextMeshProUGUI txtScore;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.persistentDataPath + "/saves.json";
        LoadSaves();
    }

    public void LoadSaves()
    {
        string json = File.ReadAllText(path);

        SaveData data = new SaveData();
        data = JsonUtility.FromJson<SaveData>(json);

        txtScore.text = $"Best Score: {data.score}";

    }

    public void StartGame()
    {
        SceneManager.LoadScene("BasicScene");
    }

}

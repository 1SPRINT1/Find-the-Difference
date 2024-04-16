using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelCounterText; 
    private int currentLevel;

    private void Awake()
    {
       LoadSettingLevel(); 
    }

    private void LoadSettingLevel()
    {
        string path = Application.persistentDataPath + "/levelData.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            LevelData data = JsonUtility.FromJson<LevelData>(json);
            currentLevel = data.level;
        }
        else
        {
            currentLevel = 1; 
        }
        levelCounterText.text = "Level: " + currentLevel;
    }

    public void RestartLevel()
    {
        currentLevel++;
        SaveLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void SaveLevel()
    {
        LevelData data = new LevelData();
        data.level = currentLevel;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/levelData.json", json);
    }

    [System.Serializable]
    public class LevelData
    {
        public int level;
    }
}
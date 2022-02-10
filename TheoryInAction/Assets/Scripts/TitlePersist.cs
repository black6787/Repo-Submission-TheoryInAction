using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TitlePersist : MonoBehaviour
{
    public static TitlePersist Instance;
    public string namePlayer;

    private void Awake() //declare static Instance
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        LoadNamePlayer();
    }

    [System.Serializable] //SaveData class for DataPersist between Session
    class SaveData { public string namePlayer; }

    public void SaveNamePlayer()
    {
        SaveData data = new SaveData();
        data.namePlayer = namePlayer;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadNamePlayer()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            namePlayer = data.namePlayer;
        }
    }
}

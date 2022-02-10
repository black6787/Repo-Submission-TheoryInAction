using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePersist : MonoBehaviour
{
    public static TitlePersist Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleManager : MonoBehaviour
{
    public void ButtonContinue() //LoadScene
    {
        SceneManager.LoadScene(1);
    }

    public void GetName(string s) //Get txt from button to static value
    {
        TitlePersist.Instance.namePlayer = s;
    }

    public void Exit()
    {
        TitlePersist.Instance.SaveNamePlayer();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}

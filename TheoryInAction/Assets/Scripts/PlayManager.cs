using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    private void Awake() //Change txt
    {
        Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        //txtMy.text = $"user: {TitlePersist.Instance.namePlayer}";
    }

    public void ButtonBack() //LoadScene
    {
        SceneManager.LoadScene(0);
    }
}

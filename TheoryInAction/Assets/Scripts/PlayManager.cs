using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    private void Start()
    {
        Text txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        txtMy.text = "The Text is Changed";
    }
}

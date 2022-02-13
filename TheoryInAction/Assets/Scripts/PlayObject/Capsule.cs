using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : AllObject
{
    private string obj;
    private string color;

    private void Start()
    {
        obj = "The object is Capsule";
        color = "The color is Red";
    }

    private void Update()
    {
        
    }


    protected override void WhenMouseCliked()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log(obj);
        Debug.Log(color);
    }
}

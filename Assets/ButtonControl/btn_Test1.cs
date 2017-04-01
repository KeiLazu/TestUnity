using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class btn_Test1 : MonoBehaviour {

    public Text lbl_TestSubject;

    protected string _FirstText = "First Text";
    protected string _SecondText = "Second Text";

    protected int i = 0;

    private void Start()
    {
        
    }

    public void ChangeTextSubjectFirst()
    {
        i++;

        lbl_TestSubject.text = _FirstText;

        if (i>0)
        {
            Debug.Log(i.ToString());
        }

    }

    public void ChangeTextSubjectSecond()
    {

        i++;

        lbl_TestSubject.text = _SecondText;

        if (i > 0)
        {
            Debug.Log(i.ToString());
        }

    }

}

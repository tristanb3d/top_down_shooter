using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    //public static int scorepoints;
    public Text texty;
    public static int scorecount = 0;

    private void Awake()
    {
        texty = GetComponent<Text>();
        scorecount = 0;
       // Cursor.visible = false;
    }
    private void Update()
    {
        texty.text = "Score: " + scorecount;
    }

}

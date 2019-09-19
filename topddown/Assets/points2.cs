using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points2 : MonoBehaviour
{
    //public static int scorepoints;
    public Text texty2;
    public static int scorecount ;

    private void x()
    {
        texty2 = GetComponent<Text>();
        //scorecount = scorecount;
        // Cursor.visible = false;
    }
    private void Update()
    {
        texty2.text = "high: " + scorecount;
    }

}

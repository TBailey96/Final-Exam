using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStats : MonoBehaviour
{
    public Text txtMain;
    void Start()
    {
        txtMain.text = "Speed: " + Variables.speed.ToString() + "\n"
            + "Size: " + Variables.size.ToString() + "\n"
            + "Score: " + Variables.points.ToString() + "\n"
            + "Lives: " + Variables.lives.ToString();
    }

}

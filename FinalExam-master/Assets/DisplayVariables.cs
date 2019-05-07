using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayVariables : MonoBehaviour
{
    public Text txtSpeed, textSize, txtPoints, txtLives;
    // Start is called before the first frame update
    void Update()
    {
        txtSpeed.text = Variables.speed.ToString();
        textSize.text = Variables.size.ToString();
        txtPoints.text = Variables.points.ToString();
        txtLives.text = Variables.lives.ToString();
       
    }
}

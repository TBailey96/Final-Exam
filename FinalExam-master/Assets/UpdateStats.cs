using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateStats : MonoBehaviour
{
    public void ScoreUp()
    {
        Variables.points++;
    }

    public void ScoreDown()
    {
        Variables.points--;
    }

    public void LivesUp()
    {
        Variables.lives++;
    }

    public void LivesDown()
    {
        Variables.lives--;

    }
}

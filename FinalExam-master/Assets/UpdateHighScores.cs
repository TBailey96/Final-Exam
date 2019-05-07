using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class UpdateHighScores : MonoBehaviour
{
    private int[] scores = new int[10];
    private int i = 0;
    private int x = 0;
    private string[] lines;
    private string[] allLines;

    private void Start()
    {
        lines = File.ReadAllLines(@"Assets/scores.txt");
        foreach (string line in lines)
        {
            scores[i] = Convert.ToInt32(line.Split(' ').Last());
            if (Variables.points > scores[i])
            {
                LineUpdate(x + 1 + ". " + Variables.name.ToUpper() + " " + Variables.points, x);

                x = i;
                break;
            }
            i++;
        }
    }

    private void LineUpdate(string newText, int line)
    {
        allLines = File.ReadAllLines(@"Assets/scores.txt");
        allLines[line] = newText;
        File.WriteAllLines(@"Assets/scores.txt", allLines);
    }
}
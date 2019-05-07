using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HighScoresController : MonoBehaviour
{
    public Text HighScores;
    public InputField input;
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
            //scores[i] = Convert.ToInt32(line.Split(' ').Last());
            //if (Score.CurrentScore > scores[i])
            //{
                //x = i;
                //break;
            //}
            HighScores.text += "\n" + line;
            //i++;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            /*HighScores.text = "";
            LineUpdate(x + 1 + ". " + input.text.ToUpper() + " " + Score.CurrentScore, x);
            foreach (string line in allLines)
            {
                HighScores.text += "\n" + line;
            }*/
            Variables.name = input.text;
        }
    }
    private void LineUpdate(string newText, int line)
    {
        allLines = File.ReadAllLines(@"Assets/scores.txt");
        allLines[line] = newText;
        File.WriteAllLines(@"Assets/scores.txt", allLines);
    }
}
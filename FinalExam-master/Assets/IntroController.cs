using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroController : MonoBehaviour
{
    public Slider sldSpeed, sldSize;
    public Dropdown drp;
    public Toggle tgl;

    void Update()
    {
        
    }

    public void toggle()
    {
        if(tgl.isOn)
            sldSpeed.gameObject.SetActive(true);
        else
        sldSpeed.gameObject.SetActive(false);
    }

    public void clickedNextToScores()
    {
        Variables.speed = sldSpeed.value;
        Variables.size = sldSize.value;
        SceneManager.LoadScene(1);
    }

    public void clickedNextToGame()
    {
        SceneManager.LoadScene(2);
    }

    public void clickedReplay()
    {
        SceneManager.LoadScene(0);
    }
}

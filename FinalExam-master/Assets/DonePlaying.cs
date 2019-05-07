using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DonePlaying : MonoBehaviour
{
    public Text txtPoints, txtLives;

    public void clickedNextToExit()
    {
        SceneManager.LoadScene(3);
    }
}

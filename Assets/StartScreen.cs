using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour
{
    public GameObject startScreen;

    void Start()
    {
        Time.timeScale = 0f;
        startScreen.SetActive(true);
    }

    public void PlayGame()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
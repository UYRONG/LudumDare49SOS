﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string firstScene;
    public void playGame()
    {
        SceneManager.LoadScene(firstScene);
    }
}

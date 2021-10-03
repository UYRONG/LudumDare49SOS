using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void quit()
    {
        Application.Quit();
    }
}

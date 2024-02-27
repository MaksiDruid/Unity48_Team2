using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject aboutWindow;

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void About()
    {
        aboutWindow.SetActive(!aboutWindow.activeSelf);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

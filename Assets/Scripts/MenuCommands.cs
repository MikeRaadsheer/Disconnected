using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCommands : MonoBehaviour
{

    public void ApplicationQuit()
    {
        Application.Quit();
    }

    public void DisableMenu(GameObject menu)
    {
        menu.SetActive(false);
    }

    public void EnableMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int scene;
    private SettingsManager _settings;

    private void Start()
    {
        _settings = FindObjectOfType<SettingsManager>();
    }

    public void Load()
    {
        _settings.SaveSettings();
        SceneManager.LoadScene(scene);
    }

}

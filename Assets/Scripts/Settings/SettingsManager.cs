using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    private DataHandler _data;
    private Settings _settings;
    [SerializeField]
    private UpdateFov _fovUpdater;
    [SerializeField]
    private UpdateSensitifity _sensitifityUpdater;

    private bool _updateActively = false;

    void Start()
    {
        _data = GetComponent<DataHandler>();

        _settings = _data.Load<Settings>("Settings");

        // sanity check for settings menu.
        if (_fovUpdater != null)
        {
            _fovUpdater.UpdateSettingFov += SetFov;
        }

        // sanity check for settings menu.
        if (_sensitifityUpdater != null)
        {
            _sensitifityUpdater.UpdateSettingSensitifity += SetSensitifity;
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        if (FindObjectOfType<PlayerMovement>() != null)
        {
            _updateActively = true;
        }
        else
        {
            _updateActively = true;
        }
    }

    public Settings GetSettings()
    {
        return _settings;
    }

    public void SaveSettings()
    {
        _data.Save("Settings", _settings);
    }

    public void SetFov(int _val)
    {
        _settings.Fov = _val;
        if (_updateActively)
        {
            SaveSettings();
        }
    }

    public void SetSensitifity(int _val)
    {
        _settings.MouseSensetivity = _val;
        if (_updateActively)
        {
            SaveSettings();
        }
    }
}

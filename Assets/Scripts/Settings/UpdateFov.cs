using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateFov : MonoBehaviour
{
    public Action<int> UpdateSettingFov;

    private SettingsManager _settings;
    [SerializeField]
    public TMP_Text valueTxt;
    [SerializeField]
    private Slider _slider;

    private void Start()
    {
        _settings = GetComponent<SettingsManager>();
        _slider.value = _settings.GetSettings().Fov;
        valueTxt.text = "FOV: " + _slider.value;
    }

    public void UpdateValue()
    {
        valueTxt.text = "FOV: " + _slider.value;
        
        if (UpdateSettingFov != null)
        {
            int fov = Mathf.FloorToInt(_slider.value);
            UpdateSettingFov(fov);
        }
    }
}

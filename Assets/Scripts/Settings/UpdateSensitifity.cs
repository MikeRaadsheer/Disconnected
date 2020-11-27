using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class UpdateSensitifity : MonoBehaviour
{
    public Action<int> UpdateSettingSensitifity;

    private SettingsManager _settings;
    [SerializeField]
    public TMP_Text valueTxt;
    [SerializeField]
    private Slider _slider;

    private void Start()
    {
        _settings = GetComponent<SettingsManager>();
        _slider.value = _settings.GetSettings().MouseSensetivity;
        valueTxt.text = "Sensitifity: " + _slider.value;
    }

    public void UpdateValue()
    {
        valueTxt.text = "Sensitifity: " + _slider.value;

        if (UpdateSettingSensitifity != null)
        {
            int sensitifity = Mathf.FloorToInt(_slider.value);
            UpdateSettingSensitifity(sensitifity);
        }
    }
}

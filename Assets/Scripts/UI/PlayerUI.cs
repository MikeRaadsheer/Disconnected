using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    private PlayerStats _starts;

    [SerializeField]
    private GameObject _deathScreen;

    public TMP_Text powerTxt;
    public TMP_Text scoreTxt;

    void Start()
    {
        _starts = FindObjectOfType<PlayerStats>();
        _starts.UpdatePower += SetPowerTxt;
        _starts.UpdateScore += SetScoreTxt;
    }

    private void SetPowerTxt(float value)
    {
        string _txt = "Power: " + Mathf.FloorToInt(value) + "%";
        powerTxt.text = _txt;
    }

    private void SetScoreTxt(int value)
    {
        string _txt = "Score: " + value;
        scoreTxt.text = _txt;
    }

    private void ToggleDeathScreen()
    {
        _deathScreen.SetActive(true);
    }
}

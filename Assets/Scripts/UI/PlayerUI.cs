using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    private PlayerStats _stats;

    [SerializeField]
    private GameObject _deathScreen;

    public TextMeshProUGUI powerTxt;
    public TextMeshProUGUI scoreTxt;

    void Start()
    {
        _stats = FindObjectOfType<PlayerStats>();
        _stats.UpdatePower += SetPowerTxt;
        _stats.UpdateScore += SetScoreTxt;
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

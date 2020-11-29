using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuffFilter : MonoBehaviour
{
    public Image img;
    private PlayerStats _stats;

    private void Start()
    {
        _stats = FindObjectOfType<PlayerStats>();
        _stats.UpdateIsBuffed += ToggleFilter;
        img.enabled = false;
    }

    private void ToggleFilter(bool state)
    {
        img.enabled = state;
    }

    public void SetFilterColor(Color col)
    {
        img.color = col;
    }
}

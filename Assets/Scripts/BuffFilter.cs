using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffFilter : MonoBehaviour
{
    private PlayerMovement _trigger;

    public Image img;

    [SerializeField]
    private Color[] _colors;

    private void Start()
    {
        _trigger = FindObjectOfType<PlayerMovement>();
        _trigger.IsBuffed += ToggleFilter;
    }

    void ToggleFilter(bool state, EffectType type)
    {
        if (!state)
        {
            DeactivateFilter();
            return;
        }
        else
        {
            switch (type)
            {
                case EffectType.SPEED:
                    img.color = _colors[0];
                    break;
                case EffectType.JUMP_HEIGHT:
                    img.color = _colors[1];
                    break;
            }

            ActivateFilter();
        }
    }

    void DeactivateFilter()
    {
        img.enabled = false;
    }

    void ActivateFilter()
    {
        img.enabled = true;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Settings
{
    private int fov = 60;
    private float mouseSensetivity = 100f;

    public int Fov
    {
        get
        {
            return fov;
        }

        set
        {
            fov = value;
        }
    }
    public float MouseSensetivity
    {
        get
        {
            return mouseSensetivity;
        }

        set
        {
            mouseSensetivity = value;
        }
    }
}

public enum Setting { FOV, MOUSE_SENSETIVITY }

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Settings
{
    public int Fov = 60;
    public float MouseSensetivity = 100f;

}

public enum Setting { FOV, MOUSE_SENSETIVITY }

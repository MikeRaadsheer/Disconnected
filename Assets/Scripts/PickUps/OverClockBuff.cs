﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverClockBuff : PickUp
{
    private PlayerStats _stats;
    private BuffFilter _filter;
    public Color color;

    private void Start()
    {
        _stats = FindObjectOfType<PlayerStats>();
        _filter = FindObjectOfType<BuffFilter>();
    }

    public override void Run()
    {
        _stats.MoveSpeedModifier = amount;
        _filter.SetFilterColor(color);
        _stats.ApplyBuff(duration);
    }
}

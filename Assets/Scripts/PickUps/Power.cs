using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : PickUp
{

    private PlayerStats _stats;

    public void Start()
    {
        _stats = FindObjectOfType<PlayerStats>();
    }

    public override void Run()
    {
        if (_stats.Power == _stats.MaxPower)
        {
            _stats.Score += 10;
        }else
        {
            _stats.Power += amount;
        }
    }

}

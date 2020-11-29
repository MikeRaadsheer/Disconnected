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
        _stats.Power += amount;
    }

}

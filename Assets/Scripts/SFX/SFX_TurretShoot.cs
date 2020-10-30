using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_TurretShoot : PlaySFX
{
    EnemyTurret _turret;

    void Start()
    {
        _turret = GetComponent<EnemyTurret>();

        _turret.Shoot += Run;
    }
}

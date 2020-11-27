using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Enemy : MonoBehaviour
{
    public int hp;
    public int minRange;
    public int maxRange;
    public int attackRate;

    public Enemy(){}

    public Enemy(int _hp, int _minRange, int _maxRange, int _attackRate)
    {
        this.hp = _hp;
        this.minRange = _minRange;
        this.maxRange = _maxRange;
        this.attackRate = _attackRate;
    }
}

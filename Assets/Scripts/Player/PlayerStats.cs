using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{

    private float maxPower = 100f;
    private float power = 100f;

    private float moveSpeed = 20f;
    private float moveSpeedModifier = 1f;

    private float jumpHeight = 3f;
    private float jumpHeightModifier = 1f;

    private int score = 0;

    public Action<float> UpdatePower;
    public Action<int> UpdateScore;

    public float MaxPower
    {
        get
        {
            return maxPower;
        }

        set
        {
            maxPower = value;
        }
    }

    public float Power
    {
        get
        {
            return power;
        }

        set
        {
            power = value;
            if (UpdatePower != null)
            {
                UpdatePower(power);
            }
        }
    }

    public float MoveSpeed
    {
        get
        {
            return moveSpeed;
        }

        set
        {
            moveSpeed = value;
        }
    }

    public float MoveSpeedModifier
    {
        get
        {
            return moveSpeedModifier;
        }

        set
        {
            moveSpeedModifier = value;
        }
    }

    public float JumpHeight
    {
        get
        {
            return jumpHeight;
        }

        set
        {
            jumpHeight = value;
        }
    }

    public float JumpHeightModifier
    {
        get
        {
            return jumpHeightModifier;
        }

        set
        {
            jumpHeightModifier = value;
        }
    }

    public int Scoire
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            if (UpdateScore != null)
            {
                UpdateScore(score);
            }
        }
    }
}

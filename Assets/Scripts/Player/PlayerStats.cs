using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private bool _isBuffed = false;

    private float _maxPower = 100f;
    private float _power = 100f;

    private float _moveSpeed = 20f;
    [SerializeField]
    private float _moveSpeedModifier = 1f;

    private float _jumpHeight = 3f;
    [SerializeField]
    private float _jumpHeightModifier = 1f;

    private int _score = 0;

    public Action<float> UpdatePower;
    public Action<int> UpdateScore;
    public Action<bool> UpdateIsBuffed;
    public Action<float> UpdateSpeedMod;
    public Action<float> UpdateJumpMod;

    public float MaxPower
    {
        get
        {
            return _maxPower;
        }

        set
        {
            _maxPower = value;
        }
    }

    public float Power
    {
        get
        {
            return _power;
        }

        set
        {
            _power = value;
            if (_power > _maxPower)
            {
                _power = _maxPower;
            }
            if (UpdatePower != null)
            {
                UpdatePower(_power);
            }
        }
    }

    public float MoveSpeed
    {
        get
        {
            return _moveSpeed;
        }

        set
        {
            _moveSpeed = value;
        }
    }

    public float MoveSpeedModifier
    {
        get
        {
            return _moveSpeedModifier;
        }

        set
        {
            _moveSpeedModifier = value;
            if(UpdateSpeedMod != null)
            {
                UpdateSpeedMod(value);
            }
        }
    }

    public float JumpHeight
    {
        get
        {
            return _jumpHeight;
        }

        set
        {
            _jumpHeight = value;
        }
    }

    public float JumpHeightModifier
    {
        get
        {
            return _jumpHeightModifier;
        }

        set
        {
            _jumpHeightModifier = value;
            if (UpdateJumpMod != null)
            {
                UpdateJumpMod(value);
            }
        }
    }

    public int Score
    {
        get
        {
            return _score;
        }

        set
        {
            _score = value;
            if (UpdateScore != null)
            {
                UpdateScore(_score);
            }
        }
    }

    public bool IsBuffed
    {
        get
        {
            return _isBuffed;
        }

        set
        {
            _isBuffed = value;
        }
    }

    public void ApplyBuff(float duration)
    {
        StartCoroutine(ActiveBuff(duration));
    }

    private IEnumerator ActiveBuff(float duration)
    {
        if (UpdateIsBuffed != null)
        {
            IsBuffed = true;
            UpdateIsBuffed(IsBuffed);
        }

        // X ammount of seconds timer
        yield return new WaitForSeconds(duration);

        // Reset Modifiers
        MoveSpeedModifier = 1;
        JumpHeightModifier = 1;

        if (UpdateIsBuffed != null)
        {
            IsBuffed = false;
            UpdateIsBuffed(IsBuffed);
        }
    }
}


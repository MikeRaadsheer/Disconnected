using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{
    private bool _isBuffed = false;

    private float _maxPower = 100f;
    private float _power = 100f;

    private float _moveSpeed = 20f;
    private float _moveSpeedModifier = 1f;

    private float _jumpHeight = 3f;
    private float _jumpHeightModifier = 1f;

    private int _score = 0;

    public Action<float> UpdatePower;
    public Action<int> UpdateScore;
    public Action<bool> UpdateIsBuffed;

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
            MoveSpeed = MoveSpeed * value;
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
            JumpHeight = JumpHeight * value;
        }
    }

    public int Scoire
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

    public IEnumerator ApplyBuff(float duration)
    {
        if (UpdateIsBuffed != null)
        {
            IsBuffed = true;
            UpdateIsBuffed(IsBuffed);
        }

        // X ammount of seconds timer

        // Reset Modifiers
        MoveSpeedModifier = 1;
        JumpHeightModifier = 1;

        if (UpdateIsBuffed != null)
        {
            IsBuffed = false;
            UpdateIsBuffed(IsBuffed);
        }

        yield return new WaitForEndOfFrame();
    }
}


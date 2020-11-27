using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpinner : MonoBehaviour
{

    public RotationAxis _axis = RotationAxis.Y;

    private Vector3 _startPos;

    private bool _moveUp = true;
    private float _spinSpeed = 80f;
    private float _hoverSpeed = .25f;
    private float _heightBuffer = 0.2f;

    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        float hoverAmount = Time.deltaTime * _hoverSpeed;
        float spinAmount = Time.deltaTime * _spinSpeed;

        switch (_axis)
        {
            case RotationAxis.X:
                transform.Rotate(spinAmount, 0f, 0f);
                break;
            case RotationAxis.Y:
                transform.Rotate(0f, spinAmount, 0f);
                break;
            case RotationAxis.Z:
                transform.Rotate(0f, 0f, spinAmount);
                break;
        }


        if (_moveUp)
        {
            if (transform.position.y >= _startPos.y + _heightBuffer)
            {
                _moveUp = false;
            }
            MoveVertically(hoverAmount);
        }
        else
        {
            if (transform.position.y <= _startPos.y - _heightBuffer)
            {
                _moveUp = true;
            }
            MoveVertically(-hoverAmount);
        }
    }

    private void MoveVertically(float _amount)
    {
        transform.position += new Vector3(0f, _amount, 0f);
    }

}

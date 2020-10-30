using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public Action Jump;
    public Action<bool, EffectType> IsBuffed;

    private CharacterController _controller;

    private float _buffDeactivation;
    private bool _isBuffed = false;

    private float _defaultMoveSpeed = 20f;
    private float _moveSpeed;

    [SerializeField]
    private LayerMask _groundMask;
    private Transform _groundCheck;
    private float _groundDistance = 0.4f;
    
    private float _gravity = -9.81f;
    private float _defaultJumpHeight = 3f;
    private float _jumpHeight;
    
    private Vector3 _vel;
    private bool _isGrounded;

    private void Start()
    {
        _moveSpeed = _defaultMoveSpeed;
        _jumpHeight = _defaultJumpHeight;
        _controller = GetComponent<CharacterController>();
        _groundCheck = GetComponent<Transform>();   
    }

    void FixedUpdate()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position - Vector3.up, _groundDistance, _groundMask);

        if(_buffDeactivation > 0)
        {
            _buffDeactivation -= Time.fixedDeltaTime;
        }

        if (_isBuffed && _buffDeactivation <= 0)
        {
            if(IsBuffed != null)
            {
                IsBuffed(false, EffectType.NONE);
            }
            UnityEngine.Debug.Log("Deactivate Buff");
            _moveSpeed = _defaultMoveSpeed;
            _isBuffed = false;
        }

        if (_isGrounded && _vel.y < 0)
        {
            _vel.y = -2f;
        }

        float x = Input.GetAxis("Horizontal") * _moveSpeed * Time.fixedDeltaTime;
        float z = Input.GetAxis("Vertical") * _moveSpeed * Time.fixedDeltaTime;

        Vector3 dir = transform.right * x + transform.forward * z;

        _controller.Move(dir * _moveSpeed * Time.fixedDeltaTime);

        if ((Input.GetButton("Jump") && _isGrounded))
        {
            _isGrounded = false;
            _vel.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
            if(Jump != null)
            {
                Jump();
            }
        }

        _vel.y += _gravity * Time.fixedDeltaTime;

        _controller.Move(_vel * Time.fixedDeltaTime);
    }

    private void ApplyEffect(EffectType type, float amount, float duration)
    {
        if (IsBuffed != null)
        {
            IsBuffed(true, type);
        }

        _isBuffed = true;

        _buffDeactivation = duration;

        switch (type)
        {
            case EffectType.SPEED:
                _jumpHeight = _defaultJumpHeight;
                _moveSpeed = _defaultMoveSpeed * amount;
                break;
            case EffectType.JUMP_HEIGHT:
                _moveSpeed = _defaultMoveSpeed;
                _jumpHeight = _defaultJumpHeight * amount;
                break;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Buff")
        {
            PlayerEffect effect = other.GetComponent<PlayerEffect>().GetEffect();

            ApplyEffect(effect.type, effect.modifierAmount, effect.duration);
            Destroy(other.gameObject);
        }
    }
}
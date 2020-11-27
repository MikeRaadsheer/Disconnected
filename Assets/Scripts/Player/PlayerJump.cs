using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
public class PlayerJump : MonoBehaviour
{
    public Action Jump;
    private PlayerStats _stats;
    private CharacterController _controller;

    [SerializeField]
    private LayerMask _groundMask;
    private Transform _groundCheck;
    private float _groundDistance = 0.4f;

    private static float _gravity = -9.81f;
    private float _jumpHeight;

    private Vector3 _vel;
    private bool _isGrounded;

    void Start()
    {
        _stats = GetComponent<PlayerStats>();
        _controller = GetComponent<CharacterController>();

        _jumpHeight = _stats.JumpHeight;
        _groundCheck = GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position - Vector3.up, _groundDistance, _groundMask);

        if (_isGrounded && _vel.y < 0)
        {
            _vel.y = -2f;
        }

        if ((Input.GetButton("Jump") && _isGrounded))
        {
            _isGrounded = false;
            _vel.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
            if (Jump != null)
            {
                Jump();
            }
        }

        _vel.y += _gravity * Time.fixedDeltaTime;

        _controller.Move(_vel * Time.fixedDeltaTime);
    }
}

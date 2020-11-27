using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public Action<bool, EffectType> IsBuffed;
    private PlayerStats _stats;
    private CharacterController _controller;

    private float _moveSpeed;


    private void Start()
    {
        _stats = GetComponent<PlayerStats>();
        _moveSpeed = _stats.MoveSpeed; 
        _controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * _moveSpeed * Time.fixedDeltaTime;
        float z = Input.GetAxis("Vertical") * _moveSpeed * Time.fixedDeltaTime;

        Vector3 dir = transform.right * x + transform.forward * z;

        _controller.Move(dir * _moveSpeed * Time.fixedDeltaTime);


    }
}
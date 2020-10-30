using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : Enemy
{
    public Action Shoot;

    [SerializeField]
    private Transform _head;
    [SerializeField]
    private Transform _barrel;

    [SerializeField]
    private GameObject _bulletPrefab;
    private Transform _target;

    private float _passedTime = 0;


    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        float range = Vector3.Distance(transform.position, _target.position);
        if (range < minRange && range > maxRange)
        {
            _head.transform.LookAt(_target);

            _passedTime += Time.fixedDeltaTime;


            if (_passedTime >= attackRate)
            {
                _passedTime = 0f;

                var bullet = Instantiate(_bulletPrefab, _barrel.transform.position, Quaternion.identity);
                bullet.transform.rotation = _barrel.transform.rotation;
                
                if(Shoot != null)
                {
                    Shoot();
                }
            }
        }
    }
}

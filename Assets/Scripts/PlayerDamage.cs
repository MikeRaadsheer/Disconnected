using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerDamage : MonoBehaviour
{

    [SerializeField]
    private int _hp = 3;
    private int _maxHp = 5;
    public Action<int> UpdateHp;
    public Action PlayerDie;

    private void Start()
    {
        if (UpdateHp != null)
        {
            UpdateHp(_hp);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PickUpAlert _alert = null;

        if(other.GetComponent<PickUpAlert>() != null)
        {
            _alert = other.GetComponent<PickUpAlert>();
        }

        if (other.gameObject.tag == "Attack")
        {
            if (UpdateHp != null && _hp > 0)
            {
                _hp--;
                UpdateHp(_hp);
            }
            
            if (_hp <= 0)
            {
                PlayerDie();
            }
        }

        if (other.gameObject.tag == "MedKit")
        {
            
            if(_alert != null)
            {
                _alert.Alert();
            }

            if (UpdateHp != null && _hp < _maxHp)
            {
                _hp++;
                UpdateHp(_hp);
            }
        }
    }
}

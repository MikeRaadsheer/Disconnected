﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    [SerializeField]
    private int _points = 0;
    public Action<int> UpdatePoints;

    private void OnTriggerEnter(Collider other)
    {
        PickUpAlert _alert = null;

        if (other.GetComponent<PickUpAlert>() != null)
        {
            _alert = other.GetComponent<PickUpAlert>();
        }

        
    }
}

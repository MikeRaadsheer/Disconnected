using System;
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

        if (other.gameObject.tag == "Points")
        {
            if (_alert != null)
            {
                _alert.Alert();
            }

            if (UpdatePoints != null)
            {
                Points points = other.GetComponent<Points>();
                _points += points.GetPoints();
                UpdatePoints(_points);
            }
        }
    }
}

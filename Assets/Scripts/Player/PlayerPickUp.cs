using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    private PlayerStats _stats;

    private void Start()
    {
        _stats = GetComponent<PlayerStats>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.GetComponent<PickUp>())
        {

            PickUp pickUp = other.gameObject.GetComponent<PickUp>();

            if(pickUp.type == EffectType.BUFF && _stats.IsBuffed)
            {
                Debug.Log("Already Buffed");
                return;
            }

            pickUp.Run();
        }
        
        if (other.gameObject.GetComponent<PickUpAlert>())
        {
            PickUpAlert alert = other.gameObject.GetComponent<PickUpAlert>();

            alert.Alert();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAlert : MonoBehaviour
{
    public Action<GameObject, Vector3> PickedUp;
    public GameObject obj;

    public void Alert()
    {
        if (PickedUp != null)
        {
            PickedUp(obj, transform.position);
            gameObject.SetActive(false);
        }
    }

}
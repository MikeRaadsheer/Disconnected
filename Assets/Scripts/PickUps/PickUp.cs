using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public EffectType type;
    public float duration = 0f;

    public virtual void Run()
    {
        Debug.Log("Picked Up: " + gameObject.name);
        Destroy(this);
    }
}

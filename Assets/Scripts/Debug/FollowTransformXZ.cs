using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransformXZ : MonoBehaviour
{
    public Transform target;

    void FixedUpdate()
    {
        transform.position = target.transform.position - (Vector3.up * target.transform.position.y);        
    }
}

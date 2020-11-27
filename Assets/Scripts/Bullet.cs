using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _moveSpeed = 12f;


    void Update()
    {
        transform.position += transform.forward * _moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerStats>())
        {
            other.GetComponent<PlayerStats>().Power -= 10f;
            Destroy(gameObject);
        }   
    }
}

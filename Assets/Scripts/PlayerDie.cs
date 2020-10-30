using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    private PlayerDamage _damage;

    private PlayerMovement _movement;
    private PlayerRotation _rotation;

    void Start()
    {
        _damage = GetComponent<PlayerDamage>();
        _movement = GetComponent<PlayerMovement>();
        _rotation = Camera.main.GetComponent<PlayerRotation>();
        _damage.PlayerDie += Die;
    }


    private void Die()
    {
        _movement.enabled = false;
        _rotation.enabled = false;
        GetComponent<CharacterController>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}

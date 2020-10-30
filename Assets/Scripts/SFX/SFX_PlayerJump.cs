using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_PlayerJump : PlaySFX
{
    private PlayerMovement _movement;

    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();

        _movement.Jump += Run;
    }
}

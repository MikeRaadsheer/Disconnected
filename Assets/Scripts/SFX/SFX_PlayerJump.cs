using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_PlayerJump : PlaySFX
{
    private PlayerJump _jump;

    private void Start()
    {
        _jump = GetComponent<PlayerJump>();

        _jump.Jump += Run;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_PlayerJump : PlaySFX
{
    [SerializeField]
    private PlayerJump _jump;

    private void Start()
    {
        _jump = GetComponentInParent<PlayerJump>();

        _jump.Jump += Run;
    }
}

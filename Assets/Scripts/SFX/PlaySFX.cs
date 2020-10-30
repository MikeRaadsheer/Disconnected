using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    public AudioSource _sfx;

    public virtual void Run()
    {
        _sfx.Play();
    }

}

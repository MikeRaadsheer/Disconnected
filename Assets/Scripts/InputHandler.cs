using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    public Action OpenMenu;
    private KeyCode _menu = KeyCode.Escape;

    
    void Update()
    {
        if (Input.GetKeyDown(_menu) && OpenMenu != null)
        {
            OpenMenu();
        } else if (OpenMenu == null){
            Debug.LogError("Menu cannot be opened, Deligate not picked up.");
        }
    }
}

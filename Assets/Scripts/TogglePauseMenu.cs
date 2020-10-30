using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _menu;
    private InputHandler _inputs;
    private bool _isActive = false;

    void Start()
    {
        _inputs = FindObjectOfType<InputHandler>();
        _inputs.OpenMenu += ToggleMenu;
    }

    void ToggleMenu()
    {
        if (_isActive)
        {
            _menu.SetActive(false);
            Time.timeScale = 1;
            _isActive = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            _menu.SetActive(true);
            Time.timeScale = 0;
            _isActive = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}

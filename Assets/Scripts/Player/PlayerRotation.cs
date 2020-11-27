using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField]
    private SettingsManager _settingsManager;
    private Settings _settings;

    private Camera _cam;

    public Transform _player;
    private float _mouseSensitifity = 100f;
    private float _xRot = 0f;

    private void Start()
    {
        _cam = Camera.main;
        _settingsManager = FindObjectOfType<SettingsManager>();
        _settings = _settingsManager.GetSettings();
        _mouseSensitifity = _settings.MouseSensetivity;
        _cam.fieldOfView = _settings.Fov;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitifity * Time.fixedDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitifity * Time.fixedDeltaTime;

        _xRot -= mouseY;
        _xRot = Mathf.Clamp(_xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRot, 0f, 0f);
        _player.Rotate(Vector3.up * mouseX);

        _settings = _settingsManager.GetSettings();

        // TODO: Update Sens and FOV with Action.

    }
}

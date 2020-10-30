using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class PickUpParticleSpawner : MonoBehaviour
{
    private PickUpAlert[] _alerts;

    void Start()
    {
        _alerts = FindObjectsOfType<PickUpAlert>();

        for (int i = 0; i < _alerts.Length; i++)
        {
            _alerts[i].PickedUp += SpawnParticle;
        }
    }
    void SpawnParticle(GameObject obj, Vector3 pos)
    {
        Instantiate(obj, pos, Quaternion.identity);
    }
}

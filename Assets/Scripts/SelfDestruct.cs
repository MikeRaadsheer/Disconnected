using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public bool autoActivate = false;
    public float delay = 1f;

    void Start()
    {
        if (autoActivate)
        {
            Activate();
        }
    }

    public void Activate()
    {
        Destroy(gameObject, delay);
    }
}

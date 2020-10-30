using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField]
    private int _value;

    private void Start()
    {
        _value = Mathf.FloorToInt(Random.Range(50f, 100f));
    }

    public int GetPoints()
    {
        return _value;
    }
}

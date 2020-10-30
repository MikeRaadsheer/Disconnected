using UnityEngine;

public class PlayerEffect : MonoBehaviour
{
    public float duration; // duration in seconds
    public float modifierAmount; // Strength on the effect

    public EffectType type;

    public PlayerEffect GetEffect()
    {
        return this;
    }
}

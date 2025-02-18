using UnityEngine;

public class Component : MonoBehaviour
{
    public const uint pinCount;
    public const uint compIdx;
    public Robot motherboard;

    public void SendValue(int pin, float value) {
        motherboard.SetPin(compIdx, pin, value);
    }
    public float GetValue(int pin) {
        return motherboard.GetPin(compIdx, pin);
    }
}

using UnityEngine;

public class RobotComponent : MonoBehaviour
{
    public const int pinCount = 0;
    public const int compIdx = 0;
    public Robot motherboard;

    public void SendValue(int pin, float value) {
        motherboard.SetPin(compIdx, pin, value);
    }
    public float GetValue(int pin) {
        return motherboard.GetPin(compIdx, pin);
    }
}

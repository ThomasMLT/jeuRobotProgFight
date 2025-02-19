using UnityEngine;

public class BaseWheel : Component
{

    private const int WHEEL_SPEED_INPUT_PIN = 0;

    public float speed;

    float InputToSpeed() {
        return GetValue(WHEEL_SPEED_INPUT_PIN) * 54.0f;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}

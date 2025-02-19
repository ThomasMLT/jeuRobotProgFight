using UnityEngine;

public class BaseWheel : RobotComponent
{

    private const int NUMBER_PIN = 1;   
    private const int WHEEL_SPEED_INPUT_PIN = 0;

    private Rigidbody2D rb;
    public float forceCoeff; // Could be an ESC...

    private float InputToForce() {
        //Debug.Log(GetValue(WHEEL_SPEED_INPUT_PIN));
        return GetValue(WHEEL_SPEED_INPUT_PIN) * forceCoeff;
    }


    void Awake() {
        pinCount = NUMBER_PIN;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        Vector2 direction = transform.right;
        rb.AddForce(direction * InputToForce());
        
    }
}

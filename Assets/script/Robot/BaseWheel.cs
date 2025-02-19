using UnityEngine;

public class BaseWheel : RobotComponent
{

    private const int WHEEL_SPEED_INPUT_PIN = 0;

    private Rigidbody2D rb;
    public float forceCoeff; // Could be an ESC...

    private float InputToForce() {
        return GetValue(WHEEL_SPEED_INPUT_PIN) * forceCoeff;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate() {
        Vector2 direction = transform.forward;
        rb.AddForce(direction * InputToForce());
    }
}

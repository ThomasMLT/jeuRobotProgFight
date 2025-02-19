using UnityEngine;

public class BaseSpringConnection : RobotComponent
{
    private const int NUMBER_PIN = 0;
    void Awake() {
        pinCount = NUMBER_PIN;
    }  
}

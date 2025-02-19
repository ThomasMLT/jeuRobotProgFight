using UnityEngine;

public class RobotFactory : MonoBehaviour
{
    public GameObject robot;

    public GameObject body;
    public GameObject wheel;
    

    void BuildRobot() {

        GameObject newRobot =Instantiate(robot, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(body, new Vector3(0, 0, 0), Quaternion.identity, newRobot.transform);
        Instantiate(wheel, new Vector3(0, 0, 0), Quaternion.identity, newRobot.transform);
        

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BuildRobot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

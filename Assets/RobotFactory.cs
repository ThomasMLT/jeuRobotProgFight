using UnityEngine;

public class RobotFactory : MonoBehaviour
{
    public GameObject robot;
    public GameObject body;
    public GameObject wheel;
    public GameObject springConnection;
    

    void BuildRobot() {

        GameObject newRobot = Instantiate(robot, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject Body = Instantiate(body, new Vector3(0, 0, 0), Quaternion.identity, newRobot.transform);
        GameObject wheel0 = Instantiate(wheel, new Vector3(0,0.8f,0), Quaternion.identity, newRobot.transform);
        GameObject springconnection0 = Instantiate(springConnection, new Vector3(0,0.6f,0), Quaternion.identity, newRobot.transform);
        GameObject wheel1 = Instantiate(wheel, new Vector3(0,-0.8f,0), Quaternion.identity, newRobot.transform);
        GameObject springconnection1 = Instantiate(springConnection, new Vector3(0,-0.6f,0), Quaternion.identity, newRobot.transform);
        
        // initiate connections
        SpringJoint2D[] springConnections0 = springconnection0.GetComponents<SpringJoint2D>();
        SpringJoint2D[] springConnections1 = springconnection1.GetComponents<SpringJoint2D>();
        springConnections0[0].connectedBody = Body.GetComponent<Rigidbody2D>();
        springConnections0[1].connectedBody = wheel0.GetComponent<Rigidbody2D>();
        springConnections1[0].connectedBody = Body.GetComponent<Rigidbody2D>();
        springConnections1[1].connectedBody = wheel1.GetComponent<Rigidbody2D>();


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

using UnityEngine;

public class RobotFactory : MonoBehaviour
{
    public GameObject robot;
    public GameObject body;
    public GameObject wheel;
    public GameObject springConnection;
    

    void BuildRobot() {

        GameObject[] componentObjects = new GameObject[5];
        GameObject newRobot = Instantiate(robot, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject Body = Instantiate(body, new Vector3(0, 0, 0), Quaternion.identity, newRobot.transform);
        componentObjects[0] = Body;

        GameObject wheel0 = Instantiate(wheel, new Vector3(0,0.7f,0), Quaternion.identity, newRobot.transform);
        componentObjects[1] = wheel0;
        GameObject springconnection0 = Instantiate(springConnection, new Vector3(0,0.55f,0), Quaternion.identity, newRobot.transform);
        componentObjects[2] = springconnection0;
        GameObject wheel1 = Instantiate(wheel, new Vector3(0,-0.7f,0), Quaternion.identity, newRobot.transform);
        componentObjects[3] = wheel1;
        GameObject springconnection1 = Instantiate(springConnection, new Vector3(0,-0.55f,0), Quaternion.identity, newRobot.transform);
        componentObjects[4] = springconnection1;
        
        // initiate connections
        SpringJoint2D[] springConnections0 = springconnection0.GetComponents<SpringJoint2D>();
        SpringJoint2D[] springConnections1 = springconnection1.GetComponents<SpringJoint2D>();
        springConnections0[0].connectedBody = Body.GetComponent<Rigidbody2D>();
        springConnections0[1].connectedBody = wheel0.GetComponent<Rigidbody2D>();
        springConnections1[0].connectedBody = Body.GetComponent<Rigidbody2D>();
        springConnections1[1].connectedBody = wheel1.GetComponent<Rigidbody2D>();


        // creation components
        Robot robotScript = newRobot.GetComponent<Robot>(); 
        for (int i = 0; i < componentObjects.Length; i++) {
            RobotComponent component = componentObjects[i].GetComponent<RobotComponent>();
            component.compIdx = i;
            component.motherboard = robotScript;
            robotScript.components.Add(component);
        }
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

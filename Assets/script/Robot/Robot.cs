using System.Collections.Generic;
using UnityEngine;


public class Robot : MonoBehaviour
{
    public List<RobotComponent> components;
    public List<int> componentsIndices;
    public List<float> pins; // Pins take a value between -5.0 and 5.0 to work as intended, higher values might dammage the system 
    private int pinCount = 0;

    private int GetCompPin(int compIdx, int compPin) {
        return componentsIndices[compIdx-1] + compPin;
    }

    public void SetPin(int compIdx, int pinIdx, float value) {
        pins[GetCompPin(compIdx, pinIdx)] = value;
    }
    public void SetPin(int absIdx, float value) {
        pins[absIdx] = value;
    }

    public float GetPin(int compIdx, int pinIdx) {
        return pins[GetCompPin(compIdx, pinIdx)];
    }
    public float GetPin(int absIdx) {
        return pins[absIdx];
    }

    void initRobot() {
        for ( int i = 0; i < components.Count; i++ ) {
            for ( int j = 0; j < components[i].pinCount; j++ ) {
                componentsIndices.Add(pinCount);
                pins.Add(0.0f);
                pinCount++;
            }
        }
    }

    private float[] interpretor(float[] inputs){
        float[] pins = new float[pinCount];
        for (int i = 0; i < pinCount; i++) {
            pins[i] = 0.0f;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            for (int i = 0; i < pinCount; i++) {
                pins[i] = 1.0f;
            }
        }
        return pins;
    }

    void Start()
    {
        initRobot();
    }

    // Update is called once per frame
    void Update()
    {
        float[] currentPins = interpretor(new float[0]);
        for (int i = 0; i < pinCount; i++) {
            pins[i] = currentPins[i];
        }
    }
}

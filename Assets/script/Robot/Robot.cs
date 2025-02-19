using System.Collections.Generic;
using UnityEngine;

public struct Connection {
    uint interpreterPin;
    uint componentPin;

    float value;
}

public class Robot : MonoBehaviour
{
    public List<Component> components;
    public List<int> componentsIndices;
    public List<float> pins;

    private int GetCompPin(int compIdx, int compPin) {
        return componentsIndices[compIdx] + compPin;
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

    void Start()
    {
        // TODO : fill componentsIndices
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

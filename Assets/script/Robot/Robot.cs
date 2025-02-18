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
    public List<uint> componentsIndices;
    public List<float> pins;

    private uint GetCompPin(uint compIdx, uint compPin) {
        return componentsIndices[compIdx] + compPin;
    }

    public void SetPin(uint compIdx, uint pinIdx, float value) {
        pins[GetCompPin(compIdx, pinIdx)] = value;
    }
    public void SetPin(uint absIdx, float value) {
        pins[absIdx] = value;
    }

    public float GetPin(uint compIdx, uint pinIdx) {
        return pins[GetCompPin(compIdx, pinIdx)];
    }
    public float GetPin(uint absIdx) {
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

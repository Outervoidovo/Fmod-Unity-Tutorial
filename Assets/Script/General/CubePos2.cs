using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePos2 : MonoBehaviour
{
    public Transform Object;
    public Transform Camera;
    float CubeX,CubeY,CubeZ;
    private float distance;
    
    void Start()
    {
        Object.localPosition = new Vector3(CubeX,100,0);
        CubeY = 30;
        CubeZ = 0;
    }
    void Update()
    {
        Object.localPosition = new Vector3(CubeX,CubeY,CubeZ);
        distance = (Object.localPosition - Camera.localPosition).magnitude;
    }

    public void CubeMoveX(float SliderValue)
    {
        CubeX = SliderValue * 100 - 50;
    }
    public void CubeMoveY(float SliderValue)
    {
        CubeY = SliderValue * 25 + 5;
    }
    public void CubeMoveZ(float SliderValue)
    {
        CubeZ = SliderValue * 100 - 50;
    }
    public void PrintDistace()
    {
        print("Distance = " + distance);
    }
}

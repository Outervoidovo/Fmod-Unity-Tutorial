using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePos : MonoBehaviour
{
    float CubeX,CubeY;
    
    void Start()
    {
        transform.localPosition = new Vector3(CubeX,100,0);
        CubeY = 30;
    }
    void Update()
    {
        transform.localPosition = new Vector3(CubeX,CubeY,0);
    }

    public void CubeMoveX(float SliderValue)
    {
        CubeX = SliderValue * 50 - 25;
    }
    public void CubeMoveY(float SliderValue)
    {
        CubeY = SliderValue * 25 + 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePosX : MonoBehaviour
{
    float CubeX;
    void Start()
    {
        transform.localPosition = new Vector3(0,0,0);
    }
    void Update()
    {
        transform.localPosition = new Vector3(CubeX,0,0);
    }
    public void CubeMove(float SliderValue)
    {
        CubeX = SliderValue * 1000 - 500;
    }
}

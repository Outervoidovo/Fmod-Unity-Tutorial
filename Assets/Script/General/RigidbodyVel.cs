using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyVel : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Speed , 0 , 0);
    }
}

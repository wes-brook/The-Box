using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPhysics : MonoBehaviour
{
    Rigidbody b_Rigidbody;
    float b_Speed;

    // Start is called before the first frame update
    void Start()
    {
        b_Rigidbody = GetComponent<Rigidbody>();
        b_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        b_Rigidbody.velocity = transform.up * (-b_Speed);
    }
}

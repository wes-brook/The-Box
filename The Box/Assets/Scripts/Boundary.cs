using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{

    Camera cam;
    float width;
    float height;

    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FindBoundries()
    {
        width = 1 / (cam.WorldToViewportPoint(new Vector3(1, 1, 0)).x - 0.5f);
        height = 1 / (cam.WorldToViewportPoint(new Vector3(1, 1, 0)).y - 0.5f);
    }
}

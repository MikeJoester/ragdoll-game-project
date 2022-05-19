using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryObject : MonoBehaviour
{
    private BoxCollider2D bounds;
    private CameraController camera;
    
    void Start()
    {
        bounds = GetComponent<BoxCollider2D>();
        camera = FindObjectOfType<CameraController>();
        camera.SetBounds(bounds);
    }
}

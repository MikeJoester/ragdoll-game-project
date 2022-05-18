using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour
{
    private PlayerMovements player;
    private CameraController camera;

    public Vector2 startDirection;

    public string pointName;

    void Start() {
        player = FindObjectOfType<PlayerMovements>();
        player.transform.position = transform.position;
        Debug.Log(transform.position);
        // player.lastPosition = startDirection;

        // if (player.startPoint == pointName) {
            
        // }
        

        camera = FindObjectOfType<CameraController>();
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

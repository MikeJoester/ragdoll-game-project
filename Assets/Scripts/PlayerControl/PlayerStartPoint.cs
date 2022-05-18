using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStartPoint : MonoBehaviour
{
    private PlayerMovements player;
    private CameraController camera;

    public Vector2 startDirection;

    private string[] sceneList = {"Map1", "Map2", "Playground"};

    public string pointName;

    void Start() {
        player = FindObjectOfType<PlayerMovements>();


        //scaling player
        if (!sceneList.Contains(SceneManager.GetActiveScene().name)) {
            player.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        else {
            player.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        
        // player.lastPosition = startDirection;

        if (player.startPoint == pointName) {
            player.transform.position = transform.position;

            camera = FindObjectOfType<CameraController>();
            camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

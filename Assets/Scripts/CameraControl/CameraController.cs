using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    private static bool cameraExists;

    void Start() {
        // if (!cameraExists) {
        //     cameraExists = true;
        //     DontDestroyOnLoad(transform.gameObject);
        // }
        // else {
        //     Destroy(gameObject);
        // }
    }

    void LateUpdate() {
        if (transform.position != target.position) {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            
            targetPosition.x = Mathf.Clamp(target.position.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(target.position.y, minPosition.y, maxPosition.y);
            
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}

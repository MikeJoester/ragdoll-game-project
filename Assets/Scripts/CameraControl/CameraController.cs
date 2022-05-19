using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    public BoxCollider2D boundBox;
    private Vector2 minPosition;
    private Vector2 maxPosition;

    private Camera camera;
    private float halfHeight;
    private float halfWidth;

    private static bool cameraExists;

    void Start() {
        if (!cameraExists) {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else {
            Destroy(gameObject);
        }

        minPosition = boundBox.bounds.min;
        maxPosition = boundBox.bounds.max;

        camera = GetComponent<Camera>();
        halfHeight = camera.orthographicSize;
        halfWidth = 2 * halfHeight * (Screen.width / Screen.height);
    }

    void Update() {
        if (transform.position != target.position) {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            
            targetPosition.x = Mathf.Clamp(target.position.x, minPosition.x + halfWidth, maxPosition.x - halfWidth);
            targetPosition.y = Mathf.Clamp(target.position.y, minPosition.y + halfHeight, maxPosition.y - halfHeight);
            
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

            if (boundBox == null) {
                boundBox = FindObjectOfType<BoundaryObject>().GetComponent<BoxCollider2D>();
                minPosition = boundBox.bounds.min;
                maxPosition = boundBox.bounds.max;
            }

            // float clampedX = Mathf.Clamp(transform.position.x, minPosition.x + halfWidth, maxPosition.x - halfWidth);
            // float clampedY = Mathf.Clamp(transform.position.y, minPosition.y + halfHeight, maxPosition.y - halfHeight);
            // transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }

    public void SetBounds(BoxCollider2D newBounds) {
        boundBox = newBounds;

        minPosition = boundBox.bounds.min;
        maxPosition = boundBox.bounds.max;
    }
}

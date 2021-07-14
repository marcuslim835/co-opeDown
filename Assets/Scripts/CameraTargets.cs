using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraTargets : MonoBehaviour
{

    public List<Transform> targets;

    public Vector3 offset;
    public float smoothTime = 0.3f;

    public float minZoom = 97.5f;
    public float maxZoom = 45f;
    public float zoomLimit = 25f;

    private Vector3 velocity;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }
    void LateUpdate()
    {
        Move();
        Zoom();
    }

    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDist() / zoomLimit);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
    }

    float GetGreatestDist()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        bounds.Encapsulate(targets[1].position);
        return bounds.size.x;
    }

    Vector3 GetCenterPoint()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        bounds.Encapsulate(targets[1].position);
        return bounds.center;
    }
}

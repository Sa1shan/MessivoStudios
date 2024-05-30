using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{
    public float zoomSpeed = 10.0f;
    public float minOrthographicSize = 1.0f;
    public float maxOrthographicSize = 10.0f;

    private Camera camera;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");
        camera.orthographicSize -= zoomInput * zoomSpeed * Time.deltaTime;

        
        camera.orthographicSize = Mathf.Clamp(camera.orthographicSize, minOrthographicSize, maxOrthographicSize);
    }
}

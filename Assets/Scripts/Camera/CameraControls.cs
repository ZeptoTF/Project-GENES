using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float zoomStep = 0.1f, minZoom = 30, maxZoom = 1;

    private Vector3 dragOrigin;


    private void LateUpdate()
    {
        PanCamera();
        //For now no scroll wheel.
        ZoomCamera();
    }

    private void PanCamera()
    {
        //Save position of mouse in world space when drag starts (first time clicked)
        if (Input.GetMouseButtonDown(1))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);

        //Calculate distance between origin and new position if it's still held down
        if (Input.GetMouseButton(1))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);

            //Move camera by that distance
            cam.transform.position += difference;
        }
    }

    private void ZoomCamera()
    {
        if (Input.GetKey(KeyCode.E))
        {
            float newSize = cam.orthographicSize - zoomStep;
            cam.orthographicSize = Mathf.Clamp(newSize, maxZoom, minZoom);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            float newSize = cam.orthographicSize + zoomStep;
            cam.orthographicSize = Mathf.Clamp(newSize, maxZoom, minZoom);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    [SerializeField] Camera cam;

    private Vector3 dragOrigin;

    private void LateUpdate()
    {
        PanCamera();
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
}

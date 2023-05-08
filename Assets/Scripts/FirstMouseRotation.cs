using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMouseRotation : MonoBehaviour
{
    private Camera cam;
    private Vector3 mousePos;

    void Start()
    {
        cam = Camera.main;
        rotationToMouse();
    }
    public void rotationToMouse()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90f);
    }
}

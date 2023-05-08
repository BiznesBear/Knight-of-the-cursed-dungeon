using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleToMouse : MonoBehaviour
{
    [SerializeField] bool variant;
    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (variant)
        {
            if (mousePos.x < Screen.width / 2)
            {
                transform.localScale = new Vector3(-1, -1, 1);
            }
            else if (mousePos.x > Screen.width / 2)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else
        {
            if (mousePos.x < Screen.width / 2)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (mousePos.x > Screen.width / 2)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}

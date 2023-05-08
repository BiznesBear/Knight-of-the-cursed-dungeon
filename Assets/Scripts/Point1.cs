using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point1 : MonoBehaviour
{
    public GameObject[] presets;
    private int range;
    public int floor;
    void Start()
    {
        floor = 0;
        range = Random.Range(0, presets.Length);
        var preset = Instantiate(presets[range]);
        preset.transform.parent = gameObject.transform;
        preset.transform.position = gameObject.transform.position;
    }

}

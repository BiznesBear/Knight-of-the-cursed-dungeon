using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DungeonGenerating : MonoBehaviour
{
    [Header("Floors 0-4")]
    public GameObject[] rooms1;
    [Space(10)]
    [Header("Floors 5-9")]
    public GameObject[] rooms2;
    [Space(10)]
    [Header("Floors 10-14")]
    public GameObject[] rooms3;
    [Space(10)]
    [Header("Floors 15-19")]
    public GameObject[] rooms4;

    private int range;
    public int floor=0;
    public int dungeonType=0;

    void Start()
    {
        DungeonTyping();
        if(dungeonType == 0)
        {
            range = Random.Range(0, rooms1.Length);
            var preset = Instantiate(rooms1[range]);
            preset.transform.parent = gameObject.transform;
            preset.transform.position = gameObject.transform.position;
        }
        else if (dungeonType == 1)
        {
            range = Random.Range(0, rooms2.Length);
            var preset = Instantiate(rooms2[range]);
            preset.transform.parent = gameObject.transform;
            preset.transform.position = gameObject.transform.position;
        }
        else if (dungeonType == 2)
        {
            range = Random.Range(0, rooms3.Length);
            var preset = Instantiate(rooms3[range]);
            preset.transform.parent = gameObject.transform;
            preset.transform.position = gameObject.transform.position;
        }
        else if (dungeonType == 3)
        {
            range = Random.Range(0, rooms4.Length);
            var preset = Instantiate(rooms4[range]);
            preset.transform.parent = gameObject.transform;
            preset.transform.position = gameObject.transform.position;
        }
        else if (dungeonType == 4)
        {
            range = Random.Range(0, rooms4.Length);
            var preset = Instantiate(rooms4[range]);
            preset.transform.parent = gameObject.transform;
            preset.transform.position = gameObject.transform.position;
        }
    }
    // set dungeon type 
    void DungeonTyping()
    {
        floor = PlayerPrefs.GetInt("floor");
        if(floor >  0 && floor < 4)
        {
            dungeonType = 0;
        }
        else if (floor > 4 && floor < 9)
        {
            dungeonType = 1;
        }
        else if (floor > 9 && floor < 14)
        {
            dungeonType = 2;
        }
        else if (floor > 14 && floor < 18)
        {
            dungeonType = 3;
        }
        else if (floor == 20)
        {
            dungeonType = 4;
        }
        PlayerPrefs.SetInt("floor", floor);
        PlayerPrefs.Save();

    }
}

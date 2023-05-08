using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class RoomLighter : MonoBehaviour
{
    public GameObject Light;
    private GameObject player;
    public bool isPlayerIn;

    private void Start()
    {
        
        isPlayerIn = false;
        player = GameObject.FindGameObjectWithTag("player");
    }
    private void Update()
    {
        
        if (isPlayerIn)
        {
            Light.SetActive(true);
        }
        else
        {
            Light.SetActive(false);
        }
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("player"))
    //    {
    //        isPlayerIn = true;
    //    }
    //}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            isPlayerIn = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("player"))
        {
            isPlayerIn = false;
        }
    }
}

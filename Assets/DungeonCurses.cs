using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCurses : MonoBehaviour
{
    public string[] curses;
    public int curseIndex;

    private GameObject player;
    private GameObject DamageLine;

    public int TakeHp = 0;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player");
        curseIndex = Random.Range(0,curses.Length);
        Debug.Log(curses[curseIndex]);
        if(curseIndex  == 0)
        {
            player.GetComponent<PlayerStats>().scaler = 2;
        }
        else if (curseIndex == 2)
        {
            TakeHp = 10;
        }
        else if (curseIndex == 3)
        {
            TakeHp = 20;
        }
        else if (curseIndex == 4)
        {
            TakeHp = 30;
        }

    }



}

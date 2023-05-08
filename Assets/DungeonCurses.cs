using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCurses : MonoBehaviour
{
    public string[] curses;
    public int curseIndex;

    private GameObject player;
    private GameObject DamageLine;
    private void Start()
    {
        DamageLine = GameObject.FindGameObjectWithTag("WeponController");
        player = GameObject.FindGameObjectWithTag("player");
        curseIndex = Random.Range(0,curses.Length);
        Debug.Log(curses[curseIndex]);
        if(curseIndex  == 0)
        {
            player.GetComponent<PlayerStats>().scaler = 2;
        }
        else if(curseIndex == 1)
        {
            DamageLine.GetComponent<DamageLine>().scaler = 2;
        }
        else if (curseIndex == 2)
        {
            TakeStartHp(10);
        }
        else if (curseIndex == 3)
        {
            TakeStartHp(20);
        }
        else if (curseIndex == 4)
        {
            TakeStartHp(30);
        }

    }

    void TakeStartHp(int amount)
    {
        player.GetComponent<PlayerStats>().TakeDamage(amount);
    }
}

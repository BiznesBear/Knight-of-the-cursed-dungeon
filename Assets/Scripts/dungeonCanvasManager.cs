using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dungeonCanvasManager : MonoBehaviour
{
    public PlayerStats playerStats;
    public DungeonCurses DungeonCurses;
    public Text healthText;
    public Text coinsText;
    public Text curseText;
    



    private void Update()
    {
        healthText.text = playerStats.health.ToString() + "/" + playerStats.max_health.ToString();
        coinsText.text = "x"+playerStats.coins.ToString();
        curseText.text = DungeonCurses.curses[DungeonCurses.curseIndex].ToString();
    }
}

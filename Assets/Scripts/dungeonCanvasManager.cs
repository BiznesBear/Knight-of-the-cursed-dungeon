using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dungeonCanvasManager : MonoBehaviour
{
    public PlayerStats playerStats;
    public Text healthText;
    public Text coinsText;



    private void Update()
    {
        healthText.text = playerStats.health.ToString() + "/" + playerStats.max_health.ToString();
        coinsText.text = "x"+playerStats.coins.ToString();
    }
}

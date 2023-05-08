using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class campCanvasManager : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    public Text coinsText;
    public Text flamesText;
    private void Update()
    {
        coinsText.text = "x"+ playerStats.coins.ToString();
        flamesText.text = "x" + playerStats.flames.ToString();
    }
}

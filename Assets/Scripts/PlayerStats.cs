using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private float randomFloat;
    private int randomInt;
    public int scaler=1;
    [Header("Dungeon stats")]
    public float health=100;
    public float max_health=100;
    public int souls = 0;
    //public int shileds=0;
    [Header("Camp stats")]
    public int coins=0;
    public int level;
    public int flames;

    DungeonCurses curses;

    private void Start()
    {
        curses = GameObject.FindGameObjectWithTag("DungeonGenerator").GetComponent<DungeonCurses>();
        
        LoadingValues();
        TakeDamage(curses.TakeHp);

        
    }
    private void FixedUpdate()
    {
        SaveValues();
    }
    public void Heal(float amount)
    {
        if(amount >= max_health || health + amount == max_health)
        {
            health = max_health;
        }
        else
        {
            health += amount;
        }
    }
    public void TakeDamage(float amount)
    {
        health -= amount * scaler;
        if(health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        SaveValues();
        SceneManager.LoadScene("camp");
    }

    public void CoinsManage(int amount,bool add)
    {
        if (add)
        {
            coins += amount;
        }
        else
        {
            coins -= amount;
        }
        SaveValues();
    }
    public void LevelManage(bool up)
    {
        if (up)
        {
            level += 1;
        }
        else if (!up)
        {
            level -= 1;
        }
        SaveValues();
        
    }
    public void FlamesManage(int amount,bool add)
    {
        if (add)
        {
            flames += amount;
        }
        else
        {
            flames -= amount;
        }
        SaveValues();
    }

    public void StatsManage(int var,bool add,int amount)
    {
        if (add)
        {
            var += amount;
        }
        else
        {
            var -= amount;
        }
        SaveValues();
    }
    public void SaveValues()
    {
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("flames", flames);
        PlayerPrefs.Save();
    }
    public void LoadingValues()
    {
        coins = PlayerPrefs.GetInt("coins");
        level = PlayerPrefs.GetInt("level");
        flames = PlayerPrefs.GetInt("flames");
    }
    void Curse()
    {
        var curseObject = GameObject.FindGameObjectWithTag("DungeonGenerator");
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsEnemysSpawner : MonoBehaviour
{
    public GameObject[] enemys;
    private int enemyIndex;
    public int enemysCount;
    private float x;
    private float y;

    private void Start()
    {
        for (int i = 0; i < enemysCount; i++)
        {
            enemyIndex = Random.Range(0, enemys.Length);
            x = Random.Range(-5, 5);
            y = Random.Range(-5, 5);
            var enemy = Instantiate(enemys[enemyIndex]);
            enemy.transform.parent = gameObject.transform;
            enemy.transform.localPosition = new Vector3(x,y,0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject damageLine;
    public Transform damageLineTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFireing;
    public string spell;

    public EnemyAI enemyAI;

    private void Update()
    {
        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer >= timeBetweenFireing)
            {
                canFire = true;
                timer = 0;
            }
            NormalAttack();
        }

    }

    void NormalAttack()
    {
        if (enemyAI.distance < enemyAI.distanceBetween && canFire)
        {
            canFire = false;
            Instantiate(damageLine, damageLineTransform.position, Quaternion.identity);
        }
    }

}

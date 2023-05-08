using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    public GameObject damageLine;
    public Transform damageLineTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFireing;
    public string spell;

    public Animator animator;
    private void Update()
    {
        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer >= timeBetweenFireing )
            {
                canFire = true;
                timer = 0;
            }
        }
        if(spell == "normal")
        {
            NormalAttack();
        }
        else if(spell == "soul")
        {
            SoulSpell();
        }

    }

    void NormalAttack()
    {
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            animator.SetTrigger("Attack");
            canFire = false;
            Instantiate(damageLine, damageLineTransform.position, Quaternion.identity);
        }
    }
    void SoulSpell()
    {
        if (Input.GetKeyUp(KeyCode.F) && canFire)
        {
            canFire = false;
            Instantiate(damageLine, damageLineTransform.position, Quaternion.identity);
        }
    }
}

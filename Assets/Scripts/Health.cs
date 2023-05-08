using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health=10;
    public Animator animator;

    public void TakeDamage(int damage)
    {
        health -= damage;
        animator.SetTrigger("Damage");

        if(health <= 0)
        {
            Die();
        }

    }
    public void Die()
    {
        Destroy(gameObject);
    }

}

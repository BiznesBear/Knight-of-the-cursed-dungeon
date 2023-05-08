using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemBullet : MonoBehaviour
{

    private Rigidbody2D rb;
    public int damage = 6;
    public float force;
    private float timer;
    private Transform player;
    public float timeToDestroy;



    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        
        rb = GetComponent<Rigidbody2D>();
      
        Vector3 direction = player.position - transform.position;
        
        Vector3 rotation = transform.position - player.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.x, rotation.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot + 90f);
        //float rot = Mathf.Atan2(rotation.x, rotation.y) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, rot + 90f);


    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToDestroy)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerStats playerStats = hitInfo.GetComponent<PlayerStats>();
        if (playerStats != null)
        {
            playerStats.TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}

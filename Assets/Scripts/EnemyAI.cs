using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float scale;
    private Transform player;
    public float speed;
    public float distance;
    public float distanceBetween;
    [SerializeField] GameObject bullet;
    public GameObject bulletParent;
    public GameObject bulletSpawner;

    


    float timer;
    public float timeEnd=0.2f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        distance = Vector2.Distance(transform.position, player.position);
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        
        Vector3 rotation = player.position - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        bulletParent.transform.rotation = Quaternion.Euler(0, 0, rotZ);
        
        if (distance <  distanceBetween)
        {
            transform.position = Vector2.MoveTowards(transform.position,player.position, speed * Time.deltaTime);
        }

        if(transform.position.x > player.position.x)
        {
            transform.localScale = new Vector3(-scale,scale,0f);
            bulletParent.transform.localScale = new Vector3(-1f, 1f, 0f);
        }
        else
        {
            transform.localScale = new Vector3(scale, scale, 0f);
            bulletParent.transform.localScale = new Vector3(1f, 1f, 0f);
        }
        Attacking();
    }

    public void Attacking()
    {
        if(distance < distanceBetween)
        { 
            if (timer > timeEnd)
            {
                timer = 0;
                GameObject Currentbullet = Instantiate(bullet, new Vector3(bulletSpawner.transform.position.x, bulletSpawner.transform.position.y, bulletSpawner.transform.position.z), Quaternion.identity);

            }
        }

    }

}

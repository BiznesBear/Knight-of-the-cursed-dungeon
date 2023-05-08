using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DamageLine : MonoBehaviour
{
    private GameObject weponController;
    private Vector3 mousePos;
    private Camera mainCamera;
    private Rigidbody2D rb;
    public int damage=6;
    public float force;
    private float timer;
    public int scaler = 1;
    public float timeToDestroy;

    

    private void Start()
    {
        weponController = GameObject.FindGameObjectWithTag("WeponController");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2 (direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.x, rotation.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot + 90f);
        

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
        Health enemy = hitInfo.GetComponent<Health>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage/scaler);
            Destroy(gameObject);
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;
    public Projectile projectilePrefab;
    public Transform shootPoint;
    public float shootInterval;
    public float shootTimer;
    // Start is called before the first frame update
    void Shoot()
    {
        Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        shootTimer = shootInterval;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (shootTimer <= 0)
        {
            Shoot();
        }
        
        shootTimer -= Time.deltaTime;
    }
    

    void Move()
    {
        if (Input.GetMouseButton(0))
        { 
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }
}

using System;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 50;  // danno del proiettile del nemico


    void Start()
    {
        // muove il proiettile verso sinistra
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.left * speed;
    }


    public void Update()
    {
        //se i proiettili arrivano alla posizione -10 dell'asse x si distruggono (escono di scena)
        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }

    // in collisione con il tag "Player" tolgono HP e si distruggono
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthPlayer playerHealth = collision.gameObject.GetComponent<HealthPlayer>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);  
            }

            Destroy(gameObject);  
        }
    }
}

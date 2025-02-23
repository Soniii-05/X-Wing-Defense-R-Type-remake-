using System;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float velocita = 5f;

    void Start()
    {
        // Muove il proiettile verso sinistra
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.left * velocita;
    }


    public void Update()
    {
        //se i proiettili arrivano alla posizione -9.10 dell'asse x si distruggono
        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // se collide con il game object con tag "player" si distrugge
        if (collision.gameObject.CompareTag("Player"))
        {
            //e toglie hp
            Destroy(gameObject);

        }

    }
}

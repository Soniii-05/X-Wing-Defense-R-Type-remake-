using System;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    internal void SetVelocity(Vector3 direction)
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        //se i proiettili arrivano alla posizione -9.10 dell'asse x si distruggono
        if (transform.position.x >= -9.10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // se collide con il game object con tag "player" si distrugge
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);

        }

    }
}

using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody2D rb;

    internal void SetVelocity(Vector3 direction)
    {
        throw new NotImplementedException();
    }
    public void Update() 
    {
        if (transform.position.x >= 9.10f)
        {
            Destroy(gameObject);
        }
    }

}

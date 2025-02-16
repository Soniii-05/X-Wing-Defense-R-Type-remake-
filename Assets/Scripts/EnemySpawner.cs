using System;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private Transform muzzle;
    [SerializeField] private Direction bulletDirection;
    [SerializeField] private GameObject bulletToSpawn;

    [SerializeField] private float fireRate = 2f;
    private float _currentTime = 0f;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= fireRate)
        {
            GameObject projectile = Instantiate(bulletToSpawn, muzzle.position, muzzle.rotation);

            Vector3 direction = (bulletDirection) switch
            {
                Direction.Left => Vector3.left,
                Direction.Right => Vector3.right,
                _ => throw new NotImplementedException(),
            };

            muzzle.localPosition = new Vector3(direction.x, 0.5f);

            //bulletToSpawn.SetVelocity(direction);

            _currentTime = 0f;
        }
    }

    private enum Direction { Left, Right }
}

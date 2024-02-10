using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform turret;
    public float shootForce = 15f;
    public float shootAngle = 30f; // Angle of projection in degrees
    public float shootCooldown = 0.75f;

    private float lastShootTime;

    // Object pool variables
    public int poolSize = 10;
    private Queue<GameObject> bulletPool;

    void Start()
    {
        // Initialize bullet pool
        InitializeBulletPool();
    }

    void InitializeBulletPool()
    {
        bulletPool = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time - lastShootTime > shootCooldown)
        {
            Shoot();
            lastShootTime = Time.time;
        }
    }

    void Shoot()
    {
        GameObject bullet = GetPooledBullet();
        if (bullet != null)
        {
            bullet.transform.position = turret.position;
            bullet.transform.rotation = turret.rotation;

            // Calculate initial velocity for projectile motion
            Vector3 shootDirection = turret.forward;
            Vector3 shootVelocity = Quaternion.AngleAxis(shootAngle, turret.right) * shootDirection * shootForce;

            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = shootVelocity;
            bullet.SetActive(true);
        }
    }

    GameObject GetPooledBullet()
    {
        if (bulletPool.Count > 0)
        {
            return bulletPool.Dequeue();
        }
        else
        {
            // If the pool is empty, create a new bullet
            GameObject bullet = Instantiate(bulletPrefab);
            return bullet;
        }
    }

    public void ReturnBulletToPool(GameObject bullet)
    {
        if(bullet != null)
        {
            Debug.Log("Returning bullet to pool: " + bullet.name);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
        else
        {
            Debug.LogWarning("Attempted to return a null bullet to the pool.");
        }
    }
}

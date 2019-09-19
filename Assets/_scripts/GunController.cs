using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public bool isFiring;
    public BulletController bullet;
    public float bulletSpeed;
    public bool canShoot = true;

    public float timeBetweenShots;
    private float shotCounter;

    public bool isMinigun = false;

    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        timeBetweenShots = shotCounter;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring == true)
        {
            BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
            newBullet.speed = bulletSpeed;
        }
    }

    public void ShootBullet()
    {
        if (canShoot == true)
        {
            BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
            newBullet.speed = bulletSpeed;
        }
        else
        {
            return;
        }

        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {
            canShoot = true;
        }
        else
        {
            canShoot = false;
        }
        
    }
    



}

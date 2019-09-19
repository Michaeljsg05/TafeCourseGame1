﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public int minDamage = 10;
    public int maxDamage = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Destroy(gameObject, 2);


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().hurtEnemy(Random.Range(minDamage, maxDamage));
            Destroy(gameObject);
        }
    }

    public void DestroyBullet()
    {
        Debug.Log("collision");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    public int health;
    public int currentHealth;

    public GameObject lootObj;

    public float minLoot = 1;
    public float maxLoot = 3;
    


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    

    // Update is called once per frame
    void Update()
    {
        

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(lootObj, transform.position, transform.rotation);
        }
    }

    public void hurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}

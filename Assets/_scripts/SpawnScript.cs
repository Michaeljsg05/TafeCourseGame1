using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public float spawnTimer = 5;
    private float actualSpawnTimer;

    public bool isLocked = false;
    public GameObject enemy;
    public ParticleSystem spawnParticle = null; // add later

    // Start is called before the first frame update
    void Start()
    {
        actualSpawnTimer = spawnTimer;

    }

    // Update is called once per frame
    void Update()
    {
        actualSpawnTimer -= Time.deltaTime;
        if (actualSpawnTimer <= 0) // add any values
        {
            if (isLocked == false)
            {
                Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
                actualSpawnTimer = spawnTimer;
            }
            else
            {
                return;
            }
        }
        

    }
}

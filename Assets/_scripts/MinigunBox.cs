using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunBox : MonoBehaviour
{

    public bool canBuy;

    public int cost;

    public GameObject loot;
    public GameObject player;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;
    public GameObject spawner7;
    public GameObject spawner8;
    public GameObject spawner9;
    public GameObject spawner10;
    public GameObject spawner11;
    public GameObject spawner12;
    public GameObject spawner13;
    public GameObject spawner14;
    public GameObject spawner15;
    public GameObject destroyObj;

    public bool isMinigunBox = true;
    public bool isSpawnBox = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (ScoreScript.coinAmount >= cost)
            {
                Destroy(gameObject);
                if (isMinigunBox == true)
                {
                    player.GetComponent<Playercontroller>().isMinigun = true;
                }
                else if (isSpawnBox == true)
                {
                    spawner1.GetComponent<SpawnScript>().isLocked = false;
                    spawner2.GetComponent<SpawnScript>().isLocked = false;
                    spawner3.GetComponent<SpawnScript>().isLocked = false;
                    spawner4.GetComponent<SpawnScript>().isLocked = false;
                    spawner5.GetComponent<SpawnScript>().isLocked = false;
                    spawner6.GetComponent<SpawnScript>().isLocked = false;
                    spawner7.GetComponent<SpawnScript>().isLocked = false;
                    spawner8.GetComponent<SpawnScript>().isLocked = false;
                    spawner9.GetComponent<SpawnScript>().isLocked = false;
                    spawner10.GetComponent<SpawnScript>().isLocked = false;
                    spawner11.GetComponent<SpawnScript>().isLocked = false;
                    spawner12.GetComponent<SpawnScript>().isLocked = false;
                    spawner13.GetComponent<SpawnScript>().isLocked = false;
                    spawner14.GetComponent<SpawnScript>().isLocked = false;
                    spawner15.GetComponent<SpawnScript>().isLocked = false;
                    Destroy(destroyObj);
                }


            }
            else
            {
                return;
            }

        }
    }


}

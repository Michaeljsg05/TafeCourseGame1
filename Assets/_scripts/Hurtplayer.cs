using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtplayer : MonoBehaviour
{
    public int minDamageToGive = 10;
    public int maxDamageToGive = 20;
    
    public float damageTimer = 2;
    public float actualTimer;

    public bool damaged = false;

    public bool isDoingDamage = false;

    private void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
                other.gameObject.GetComponent<PlayerHealthScript>().HurtPlayer(Random.Range(minDamageToGive, maxDamageToGive));
                damaged = false;
        }

       
    }

}

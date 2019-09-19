using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUi : MonoBehaviour
{
    public Text text;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Health: " + player.GetComponent<PlayerHealthScript>().currentHealth.ToString();
        if (player.GetComponent<PlayerHealthScript>().currentHealth <= 0)
        {
            text.text = "Dead";
        }

    }
}

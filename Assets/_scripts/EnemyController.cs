using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rb;
    public Playercontroller player;
    private NavMeshAgent nma = null;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playercontroller>();
        rb = GetComponent<Rigidbody>();
        nma = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        nma.SetDestination(player.transform.position);
    }
}

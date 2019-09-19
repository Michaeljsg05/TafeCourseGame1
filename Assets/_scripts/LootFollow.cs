using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootFollow : MonoBehaviour
{

    public Playercontroller target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        target = FindObjectOfType<Playercontroller>();
    }

    void FixedUpdate()
    {
        

        Vector3 desiredPosition = target.transform.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        
        // love u brackey <3
    }
}

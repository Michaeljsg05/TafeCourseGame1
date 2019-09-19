using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootAtCameraScript : MonoBehaviour
{
    public Transform target;
    public int offsetX;
    public int offsetY;
    public int offsetZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(new Vector3(target.position.x - offsetX, target.position.y - offsetY, target.position.z - offsetZ));
    }
}

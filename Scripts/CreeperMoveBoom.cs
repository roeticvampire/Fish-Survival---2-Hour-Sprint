using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreeperMoveBoom : MonoBehaviour
{
    public float velocity = 6f;

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(transform.position.x-velocity*Time.deltaTime,transform.position.y);
        if (transform.position.x <= -12) Destroy(gameObject);
    }
}

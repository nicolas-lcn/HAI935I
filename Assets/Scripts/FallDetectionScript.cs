using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetectionScript : MonoBehaviour
{
    public Transform Spawn;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            other.transform.position = Spawn.transform.position;
            other.transform.rotation = Spawn.transform.rotation;
        }
    }
}

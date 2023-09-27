using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardBehaviour : MonoBehaviour
{
    public GameObject worldObject;
    void Start()
    {
        worldObject = GameObject.Find("World");
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            worldObject.SendMessage("AddReward");
            Destroy(gameObject);
        }
    }
}

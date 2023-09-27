using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    AudioSource collisionSound;

    [SerializeField]
    private GameObject fx;

    public GameObject worldObject;
    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = worldObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            worldObject.SendMessage("AddHit");
            if(collisionSound) collisionSound.Play();
            Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

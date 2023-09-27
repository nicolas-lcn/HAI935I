using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonTriggerBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>().text = "";
            SceneManager.LoadScene("TerrainLevel");
        }
    }
}

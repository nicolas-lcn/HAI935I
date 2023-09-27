using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    int nbCats = 0;
    TMP_Text timerText;
    int nbReward = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }

    // Update is called once per frame
    void Update()
    {
        if(nbReward == 3) 
        {
            GameObject.Find("VictoryText").SetActive(true);
            GameObject.Find("lblCats").SetActive(false);
            GameObject.Find("lblTime").SetActive(false);
        }

    }
    public void AddHit() {
        nbCats++;
        headText.text = "CatBots morts : " + nbCats;
    }

    public void AddReward() {
        nbReward++;
        headText.text = "Reward claimed : " + nbReward;
    }

    IEnumerator TimerTick() 
    {
        while (GameVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time :" + GameVariables.currentTime.ToString() + "s";
        }
        // game over
        /*SceneManager.LoadScene("TerrainLevel"); // le nom de votre scene*/
    }
}

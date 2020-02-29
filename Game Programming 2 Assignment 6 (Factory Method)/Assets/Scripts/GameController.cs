/*
* (Christopher Green)
* (GameController.cs)
* (Assignment 6)
* (This is the code for the generic checks and text updates that the game uses)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Health Stuff")]
    public Text healthText;
    public Slider healthSlider;

    [Header("Tutorial Timer and Game Timer Stuff")]
    //public Text timerText;
    public Text tutorialTimerText;
    public float duration;
    public bool skipTutorial;

    [Header("Total NPC Text")]
    public Text totalNPCText;

    [Header("Panels")]
    public GameObject gameInfo;
    public GameObject tutorialPanel;

    [Header("Player Reference")]
    public GameObject player;

    public NPCSpawner npcSpawner;
    public bool isInTutorial;

    public Text winText;
    public Text lostText;
    public Text npcType;
    public Text npcSubType;

    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        lostText.gameObject.SetActive(false);

        isInTutorial = true;
        npcSpawner.canSpawn1 = false;
        npcSpawner.canSpawn2 = false;
        npcSpawner.canSpawn3 = false;
        npcSpawner.canSpawn4 = false;

        tutorialPanel.SetActive(true);
        gameInfo.SetActive(false);
        skipTutorial = false;
        StartCoroutine(TutorialTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if(!isInTutorial)
        {
            totalNPCText.text = "Total NPC: " + GameStats.totalNPCs;
            healthSlider.value = GameStats.playerHealth;

            if (npcSpawner.AllNPCsSpawned())
            {
                player.SetActive(true);
                GameStats.playerHealth -= (4 * Time.deltaTime);
            }
        }
        GameStats.CheckGameCondition();
        if(GameStats.gameIsOver || player.transform.position.y <= -20)
        {
            StartCoroutine(DisplayText());
        }
    }

    IEnumerator DisplayText()
    {
        lostText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        GameOver();
    }

    //IEnumerator Timer()
    //{
    //    duration = 30f;

    //    while(duration >= 0)
    //    {
    //        duration -= Time.deltaTime;
    //        timerText.text = "Timer: " + duration.ToString("00");
    //        yield return null;
    //    }
    //}

    IEnumerator TutorialTimer()
    {
        isInTutorial = true;
        duration = 15;
        player.SetActive(false);

        while(duration >= 0)
        {
            duration -= Time.deltaTime;
            tutorialTimerText.text = "Timer: " + duration.ToString("00");
            yield return null;
        }

        if((duration <= 0) || (skipTutorial == true))
        {
            //StartCoroutine(Timer());
            tutorialPanel.SetActive(false);
            //player.SetActive(true);
            gameInfo.SetActive(true);
            isInTutorial = false;
            npcSpawner.canSpawn1 = true;
            npcSpawner.canSpawn2 = true;
            npcSpawner.canSpawn3 = true;
            npcSpawner.canSpawn4 = true;
        }

    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    // Button that skips the tutorial
    public void SkipTutorial()
    {
        //StartCoroutine(Timer());
        tutorialPanel.SetActive(false);
        //player.SetActive(true);
        gameInfo.SetActive(true);
        isInTutorial = false;
        skipTutorial = true;
        npcSpawner.canSpawn1 = true;
        npcSpawner.canSpawn2 = true;
        npcSpawner.canSpawn3 = true;
        npcSpawner.canSpawn4 = true;
    }

}

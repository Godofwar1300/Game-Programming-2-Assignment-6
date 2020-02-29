/*
* (Christopher Green)
* (EndGamePickup.cs)
* (Assignment)
* (This is the code for the pickup that ends the game w/o dying)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGamePickup : MonoBehaviour
{

    public GameController gameCon;

    private void Start()
    {
        gameCon = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DisplayText());
        }
    }

    IEnumerator DisplayText()
    {
        gameCon.winText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        gameCon.GameOver();
    }
}

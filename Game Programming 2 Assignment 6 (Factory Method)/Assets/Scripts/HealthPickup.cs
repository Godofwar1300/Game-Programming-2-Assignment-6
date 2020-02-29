/*
* (Christopher Green)
* (HealthPickup.cs)
* (Assignment 6)
* (This is the code for the health pickup that increases the player's health)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameStats.playerHealth += 40;
            Destroy(this.gameObject);
        }
    }
}

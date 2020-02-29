/*
* (Christopher Green)
* (GameStats.cs)
* (Assignment 6)
* (A static class that does basic checks for the game)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStats
{
    public static float playerHealth = 175;
    public static int totalNPCs = 0;

    public static bool gameIsOver = false;

    // This bool will make the player unble to move or spawn the NPCs until after the tutorial has ended or been skipped
    public static bool playerIsActive = false;


    public static void CheckGameCondition()
    {
        if(playerHealth <= 0)
        {
            gameIsOver = true;
        }
    }

}

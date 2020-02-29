/*
* (Christopher Green)
* (ShopKeeperBlacksmith.cs)
* (Assignment 6)
* (This is the code for the sub-class of the NPC class that hold some basic information (not all are used))
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperBlacksmith : NPC
{
    public ShopKeeperBlacksmith()
    {
        this.NPCs = NPCType.SHOPKEEPER;
        this.npcName = "Jerry"; //Random.Range(minIndex, maxIndex)
        this.npcAge = 30;
        this.npcGender = "male";
    }
}

/*
* (Christopher Green)
* (ShopKeeperSwordsmith.cs)
* (Assignment 6)
* (This is the code for the sub-class of the NPC class that hold some basic information (not all are used))
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperSwordsmith : NPC
{
    public ShopKeeperSwordsmith()
    {
        this.NPCs = NPCType.SHOPKEEPER;
        this.npcName = "Jessie";
        this.npcAge = 45;
        this.npcGender = "male";
    }
}

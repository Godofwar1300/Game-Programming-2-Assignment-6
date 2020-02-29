/*
* (Christopher Green)
* (CitizenTownsman.cs)
* (Assignment 6)
* (This is the code for the sub-class of the NPC class that hold some basic information (not all are used))
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenTownsman : NPC
{
    public CitizenTownsman()
    {
        this.NPCs = NPCType.CITIZEN;
        this.npcName = "Jason";
        this.npcAge = 36;
        this.npcGender = "male";
    }
}

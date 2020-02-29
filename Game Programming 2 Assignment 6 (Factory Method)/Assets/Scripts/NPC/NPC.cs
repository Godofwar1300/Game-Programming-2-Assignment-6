/*
* (Christopher Green)
* (NPC.cs)
* (Assignment 6)
* (This is the super class for NPC)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // These will be used to determine what NPC is spawned
    public enum NPCType {SHOPKEEPER, CITIZEN }
    public NPCType NPCs;

    // May or may not use these
    public string npcName;
    public string npcGender;
    public int npcAge;

}

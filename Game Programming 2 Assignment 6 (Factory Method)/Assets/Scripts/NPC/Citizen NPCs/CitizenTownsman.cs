using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenTownsman : NPC
{
    //public List<string> names = new List<string> { "Jason", "Arthur", "Lenny" };
    //public int minIndex = 0;
    //public int maxIndex = 2;

    public CitizenTownsman()
    {
        this.NPCs = NPCType.CITIZEN;
        this.npcName = "Jason";
        this.npcAge = 36;
        this.npcGender = "male";
    }
}

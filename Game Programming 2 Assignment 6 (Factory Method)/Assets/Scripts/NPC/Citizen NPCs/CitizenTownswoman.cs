using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenTownswoman : NPC
{
    //public List<string> names = new List<string> { "Claire", "Sadie", "Tilly" };
    //public int minIndex = 0;
    //public int maxIndex = 2;

    public CitizenTownswoman()
    {
        this.NPCs = NPCType.CITIZEN;
        this.npcName = "Claire";
        this.npcAge = 30;
        this.npcGender = "female";
    }
}

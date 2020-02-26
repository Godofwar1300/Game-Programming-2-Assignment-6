using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperBlacksmith : NPC
{
    //public List<string> names = new List<string> { "Reginold", "Sean", "Marcus" };
    //public int minIndex = 0;
    //public int maxIndex = 2;

    public ShopKeeperBlacksmith()
    {
        this.NPCs = NPCType.SHOPKEEPER;
        this.npcName = "Jerry"; //Random.Range(minIndex, maxIndex)
        this.npcAge = 30;
        this.npcGender = "male";
    }
}

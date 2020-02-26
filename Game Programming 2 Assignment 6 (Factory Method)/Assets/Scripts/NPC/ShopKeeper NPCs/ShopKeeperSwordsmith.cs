using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperSwordsmith : NPC
{

    //public List<string> names = new List<string> { "James", "John", "Jessie" };
    //public int minIndex = 0;
    //public int maxIndex = 2;

    public ShopKeeperSwordsmith()
    {
        this.NPCs = NPCType.SHOPKEEPER;
        this.npcName = "Jessie";
        this.npcAge = 45;
        this.npcGender = "male";
    }


}

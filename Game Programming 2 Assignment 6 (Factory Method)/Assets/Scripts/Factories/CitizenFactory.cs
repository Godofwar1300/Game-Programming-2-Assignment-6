/*
* (Christopher Green)
* (CitizenFactory.cs)
* (Assignment 6)
* (This is the code for the Citizen factory class that implements the methods from the NPCFactory abstract class for the Citizen Type NPCs)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenFactory : NPCFactory
{

    private GameObject citizenPrefab;

    public override GameObject CreateNPCPrefab(string type)
    {
        switch(type)
        {
            case "Citizen Townsman":
                citizenPrefab = Resources.Load<GameObject>("Prefabs/Citizen Townsman");
                break;
            case "Citizen Townswoman":
                citizenPrefab = Resources.Load<GameObject>("Prefabs/Citizen Townswoman");
                break;
        }
        return citizenPrefab;
    }
    public override GameObject AddNPCScript(GameObject prefab, string type)
    {
        switch(type)
        {
            case "Citizen Townsman":
                if(prefab.GetComponent<CitizenTownsman>() == null)
                {
                    prefab.AddComponent<CitizenTownsman>();
                }
                if(prefab.GetComponent<DialogueManager>() == null)
                {
                    prefab.AddComponent<DialogueManager>();
                }
                break;

            case "Citizen Townswoman":
                if (prefab.GetComponent<CitizenTownswoman>() == null)
                {
                    prefab.AddComponent<CitizenTownswoman>();
                }
                if (prefab.GetComponent<DialogueManager>() == null)
                {
                    prefab.AddComponent<DialogueManager>();
                }
                break;
        }
        return prefab;
    }
}

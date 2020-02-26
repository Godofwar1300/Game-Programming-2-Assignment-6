using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenCreator : NPCCreator
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
                if(citizenPrefab.GetComponent<CitizenTownsman>() == null)
                {
                    citizenPrefab.AddComponent<CitizenTownsman>();
                }
                if(citizenPrefab.GetComponent<DialogueManager>() == null)
                {
                    citizenPrefab.AddComponent<DialogueManager>();
                }
                break;

            case "Citizen Townswoman":
                if (citizenPrefab.GetComponent<CitizenTownswoman>() == null)
                {
                    citizenPrefab.AddComponent<CitizenTownswoman>();
                }
                if (citizenPrefab.GetComponent<DialogueManager>() == null)
                {
                    citizenPrefab.AddComponent<DialogueManager>();
                }
                break;
        }
        return citizenPrefab;
    }
}

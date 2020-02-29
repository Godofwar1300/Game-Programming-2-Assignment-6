/*
* (Christopher Green)
* (NPCSpawner.cs)
* (Assignment 6)
* (This is the code handles the NPC spawner functionality)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpawner : MonoBehaviour
{
    // Spawn locations for the NPC
    public GameObject[] NPCSpawnLocations = new GameObject[4];

    // Reference to the NPC Factory script
    public NPCFactory npcFactoryCreator;


    public bool creatorIsShopKeeper;

    // Spawn location bools to help with ensuring no more than one NPC can be spawned at a single location
    public bool canSpawn1;
    public bool npc1IsSpawned;
    public bool canSpawn2;
    public bool npc2IsSpawned;
    public bool canSpawn3;
    public bool npc3IsSpawned;
    public bool canSpawn4;
    public bool npc4IsSpawned;

    int spawnIndex = 0;

    // List of the two different types of Citizens and ShopKeepers
    string[] citizenType = new string[] { "Citizen Townsman", "Citizen Townswoman" };
    string[] shopKeeperType = new string[] { "ShopKeeper Blacksmith", "ShopKeeper Swordsmith" };

    // This allows the player, by pressing T or Y, to cycle through the different types of NPCs depending on what the current type of NPC is.
    public int NPCTypeNum = 0;

    public int totalNPCNum;

    private GameController gameController;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        npcFactoryCreator = new ShopKeeperFactory();
        creatorIsShopKeeper = true;

        canSpawn1 = true;
        canSpawn2 = true;
        canSpawn3 = true;
        canSpawn4 = true;

        spawnIndex = 0;

    }

    public GameObject SpawnNPC(string type)
    {
        GameObject npc = null;

        npc = npcFactoryCreator.CreateNPCPrefab(type);

        //if (npc.GetComponent<NPC>() != null)
        //{
        //    NPC scriptToRemove = npc.AddComponent<NPC>();
        //    DestroyImmediate(scriptToRemove, true);
        //}

        npcFactoryCreator.AddNPCScript(npc, type);

        if (canSpawn1)
        {
            Vector3 spawnArea1Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea1Location, NPCSpawnLocations[spawnIndex].transform.rotation);
            totalNPCNum += GameStats.totalNPCs++;
        }
        else if (canSpawn2)
        {
            Vector3 spawnArea2Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea2Location, NPCSpawnLocations[spawnIndex].transform.rotation);
            totalNPCNum += GameStats.totalNPCs++;
        }
        else if (canSpawn3)
        {
            Vector3 spawnArea3Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea3Location, NPCSpawnLocations[spawnIndex].transform.rotation);
            totalNPCNum += GameStats.totalNPCs++;
        }
        else if (canSpawn4)
        {
            Vector3 spawnArea4Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea4Location, NPCSpawnLocations[spawnIndex].transform.rotation);
            totalNPCNum += GameStats.totalNPCs++;
        }

        return npc;
    }

    public bool AllNPCsSpawned()
    {
        if(npc1IsSpawned && npc2IsSpawned && npc3IsSpawned && npc4IsSpawned)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(creatorIsShopKeeper)
        {
            gameController.npcType.text = "NPC Type: ShopKeeper";

            if (NPCTypeNum == 0)
            {
                gameController.npcSubType.text = "NPC Sub-Type: Blacksmith";
            }
            else
            {
                gameController.npcSubType.text = "NPC Sub-Type: Swordsmith";
            }
        }
        else
        {
            gameController.npcType.text = "NPC Type: Citizen";

            if (NPCTypeNum == 0)
            {
                gameController.npcSubType.text = "NPC Sub-Type: Townsman";
            }
            else
            {
                gameController.npcSubType.text = "NPC Sub-Type: Townswoman";
            }

        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (NPCTypeNum <= 0)
            {
                NPCTypeNum = 0;
                gameController.npcSubType.text = "NPC Sub-Type: ShopKeeper";
            }
            else if (NPCTypeNum >= 0)
            {
                NPCTypeNum--;
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (NPCTypeNum >= 1)
            {
                NPCTypeNum = 1;
            }
            else if (NPCTypeNum <= 0)
            {
                NPCTypeNum++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (creatorIsShopKeeper)
            {
                npcFactoryCreator = new CitizenFactory();
                creatorIsShopKeeper = false;
            }
            else
            {
                npcFactoryCreator = new ShopKeeperFactory();
                creatorIsShopKeeper = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spawnIndex = 0;
            if (creatorIsShopKeeper && canSpawn1)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                npc1IsSpawned = true;
                canSpawn1 = false;
            }

            if (!creatorIsShopKeeper && canSpawn1)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                npc1IsSpawned = true;
                canSpawn1 = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnIndex = 1;
            if (creatorIsShopKeeper && canSpawn2)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                npc2IsSpawned = true;
                canSpawn2 = false;
            }

            if (!creatorIsShopKeeper && canSpawn2)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                npc2IsSpawned = true;
                canSpawn2 = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spawnIndex = 2;
            if (creatorIsShopKeeper && canSpawn3)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                npc3IsSpawned = true;
                canSpawn3 = false;
            }

            if (!creatorIsShopKeeper && canSpawn3)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                npc3IsSpawned = true;
                canSpawn3 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            spawnIndex = 3;
            if (creatorIsShopKeeper && canSpawn4)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                npc4IsSpawned = true;
                canSpawn4 = false;
            }

            if (!creatorIsShopKeeper && canSpawn4)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                npc4IsSpawned = true;
                canSpawn4 = false;
            }
        }

    }
}

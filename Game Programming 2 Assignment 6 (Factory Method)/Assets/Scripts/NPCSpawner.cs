using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{

    public GameObject[] NPCSpawnLocations = new GameObject[4];
    [SerializeField]
    public NPCFactory npcFactoryCreator;
    public bool creatorIsShopKeeper;

    public bool canSpawn1;
    public bool canSpawn2;
    public bool canSpawn3;
    public bool canSpawn4;

    int spawnIndex = 0;

    public int NPCTypeNum = 0;

    string[] citizenType = new string[] { "Citizen Townsman", "Citizen Townswoman" };
    string[] shopKeeperType = new string[] { "ShopKeeper Blacksmith", "ShopKeeper Swordsmith" };


    // Start is called before the first frame update
    void Start()
    {
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
        }
        else if (canSpawn2)
        {
            Vector3 spawnArea2Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea2Location, NPCSpawnLocations[spawnIndex].transform.rotation);
        }
        else if (canSpawn3)
        {
            Vector3 spawnArea3Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea3Location, NPCSpawnLocations[spawnIndex].transform.rotation);
        }
        else if (canSpawn4)
        {
            Vector3 spawnArea4Location = NPCSpawnLocations[spawnIndex].transform.position;
            npc = Instantiate(npc, spawnArea4Location, NPCSpawnLocations[spawnIndex].transform.rotation);
        }

        return npc;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("The index for the random enemy is: " + NPCTypeNum);
        //Debug.Log("The spawnIndex is: " + spawnIndex);

        //Debug.Log("SpawnArea1: " + canSpawn1);
        //Debug.Log("SpawnArea2: " + canSpawn2);
        //Debug.Log("SpawnArea3: " + canSpawn3);
        //Debug.Log("SpawnArea4: " + canSpawn4);

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (NPCTypeNum <= 0)
            {
                NPCTypeNum = 0;
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
            Debug.Log("tab key pressed");
            Debug.Log(npcFactoryCreator.GetType());
            Debug.Log(npcFactoryCreator.GetType().Equals("FactoryMethodPatternWithGameObjects.EnemyCreator"));

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
                canSpawn1 = false;
            }

            if (!creatorIsShopKeeper && canSpawn1)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                canSpawn1 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnIndex = 1;
            if (creatorIsShopKeeper && canSpawn2)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                canSpawn2 = false;
            }

            if (!creatorIsShopKeeper && canSpawn2)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                canSpawn2 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spawnIndex = 2;
            if (creatorIsShopKeeper && canSpawn3)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                canSpawn3 = false;
            }

            if (!creatorIsShopKeeper && canSpawn3)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                canSpawn3 = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            spawnIndex = 3;
            if (creatorIsShopKeeper && canSpawn4)
            {
                SpawnNPC(shopKeeperType[NPCTypeNum]);
                canSpawn4 = false;
            }

            if (!creatorIsShopKeeper && canSpawn4)
            {
                SpawnNPC(citizenType[NPCTypeNum]);
                canSpawn4 = false;
            }
        }

    }
}

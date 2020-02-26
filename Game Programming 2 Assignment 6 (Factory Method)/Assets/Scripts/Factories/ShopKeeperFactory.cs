using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeperFactory : NPCFactory
{
    private GameObject shopkeeperPrefab;

    public override GameObject CreateNPCPrefab(string type)
    {
        switch (type)
        {
            case "ShopKeeper Blacksmith":
                shopkeeperPrefab = Resources.Load<GameObject>("Prefabs/ShopKeeper Blacksmith");
                break;
            case "ShopKeeper Swordsmith":
                shopkeeperPrefab = Resources.Load<GameObject>("Prefabs/ShopKeeper Swordsmith");
                break;
        }
        return shopkeeperPrefab;
    }
    public override GameObject AddNPCScript(GameObject prefab, string type)
    {
        switch (type)
        {
            case "ShopKeeper Blacksmith":
                if (prefab.GetComponent<ShopKeeperBlacksmith>() == null)
                {
                    prefab.AddComponent<ShopKeeperBlacksmith>();
                }
                if (prefab.GetComponent<DialogueManager>() == null)
                {
                    prefab.AddComponent<DialogueManager>();
                }
                break;
            case "ShopKeeper Swordsmith":
                if (prefab.GetComponent<ShopKeeperSwordsmith>() == null)
                {
                    prefab.AddComponent<ShopKeeperSwordsmith>();
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

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
                if (shopkeeperPrefab.GetComponent<ShopKeeperBlacksmith>() == null)
                {
                    shopkeeperPrefab.AddComponent<ShopKeeperBlacksmith>();
                }
                if (shopkeeperPrefab.GetComponent<DialogueManager>() == null)
                {
                    shopkeeperPrefab.AddComponent<DialogueManager>();
                }
                break;
            case "ShopKeeper Swordsmith":
                if (shopkeeperPrefab.GetComponent<ShopKeeperSwordsmith>() == null)
                {
                    shopkeeperPrefab.AddComponent<ShopKeeperSwordsmith>();
                }
                if (shopkeeperPrefab.GetComponent<DialogueManager>() == null)
                {
                    shopkeeperPrefab.AddComponent<DialogueManager>();
                }
                break;
        }
        return shopkeeperPrefab;
    }
}

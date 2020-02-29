/*
* (Christopher Green)
* (NPCFactory.cs)
* (Assignment 6)
* (This is the code for the abstract NPC factory class that defines two methods to be used by the different creators/factories)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCFactory
{

    public abstract GameObject CreateNPCPrefab(string type);
    public abstract GameObject AddNPCScript(GameObject prefab, string type);



}

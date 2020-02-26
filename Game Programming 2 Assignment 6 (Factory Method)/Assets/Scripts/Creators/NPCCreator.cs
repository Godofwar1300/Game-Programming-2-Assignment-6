using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCCreator
{

    public abstract GameObject CreateNPCPrefab(string type);
    public abstract GameObject AddNPCScript(GameObject prefab, string type);



}

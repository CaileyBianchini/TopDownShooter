﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SpawnManager", menuName = "Ai/SpawnManager")]

public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefabName;
    public int spawnCount;
    public float timeBetweenSpawn;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemDatabaseEntity : ScriptableObject
{
    public List<Item> items = new List<Item>();
}

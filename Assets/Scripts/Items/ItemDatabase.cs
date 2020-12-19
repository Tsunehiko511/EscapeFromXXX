using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] ItemDatabaseEntity ItemDatabaseEntity = default;
    // Itemをtypeから生成する
    public Item Spawn(Item.Type type)
    {
        for (int i=0; i< ItemDatabaseEntity.items.Count; i++)
        {
            Item itemData = ItemDatabaseEntity.items[i];
            // データベースの中からTypeの一致するものを探す
            if (itemData.type == type)
            {
                // 一致したら、Itemを生成して渡す
                return new Item(itemData);
            }
        }
        return null;
    }
}

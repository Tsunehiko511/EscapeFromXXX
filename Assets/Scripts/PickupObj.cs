using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    // アイテムの種類を設定する
    public Item.Type type = default;


    // クリックしたら消える:Trigger
    public void OnClickObj()
    {
        // データベースからアイテムを生成する
        Item item = ItemDatabase.instance.Spawn(type);
        // クリックされたら、アイテムBoxに配置される
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}

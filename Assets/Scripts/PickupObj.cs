using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    // アイテムの種類を設定する
    public Item.Type type;

    // TODO:データベースからアイテムを生成する
    // TODO:クリックされたら、アイテムBoxに配置される

    // クリックしたら消える:Trigger
    public void OnClickObj()
    {
        Item item = ItemDatabase.instance.Spawn(type);
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}

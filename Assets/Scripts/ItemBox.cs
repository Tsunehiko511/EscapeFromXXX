using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // どこかれでも利用できる変数
    public static ItemBox instance;

    private void Awake()
    {
        // 自分を入れる
        instance = this;
    }

    // クリックしたらItemを受け取る
    public void SetItem(Item item)
    {
        Debug.Log(item.type);
    }
}

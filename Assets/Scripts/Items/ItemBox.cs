using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // ItemBoxが全てのSlotを把握
    [SerializeField] Slot[] slots = default;

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
        // 左詰で入れる=左から空いてるSlotがあれば入れる
        for (int i=0; i<slots.Length; i++)
        {
            Slot slot = slots[i];
            if (slot.IsEmpty())
            {
                slot.Set(item);
                break;
            }
        }
    }
}

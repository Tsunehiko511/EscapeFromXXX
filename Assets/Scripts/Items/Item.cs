using System;
using UnityEngine;

[Serializable]// インスペクターで表示される
public class Item
{
    // 種類を持っている
    public enum Type
    {
        RedTile,
        BlueTile,
        YellowTile,
        Key,
        Coin,
    }
    public Type type;
    // 画像を持っている
    public Sprite sprite;


    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }
    
}

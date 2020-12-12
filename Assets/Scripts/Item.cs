using System;

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

    // TODO:画像を持っている

    public Item(Item item)
    {
        this.type = item.type;
    }
    
}

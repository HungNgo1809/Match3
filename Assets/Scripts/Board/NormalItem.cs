using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }
    public override void SetView(SkinConfig skinConfig)
    {
        base.SetView(skinConfig);
        View.GetComponent<SpriteRenderer>().sprite = skinConfig.skins[skinConfig.curSkin].icons[(int)ItemType];
    }
    protected override string GetPrefabName()
    {
        return Constants.PREFAB_NORMAL;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}

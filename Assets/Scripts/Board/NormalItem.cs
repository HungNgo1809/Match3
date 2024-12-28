using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE = 0,
        TYPE_TWO = 1,
        TYPE_THREE = 2,
        TYPE_FOUR = 3,
        TYPE_FIVE = 4,
        TYPE_SIX = 5,
        TYPE_SEVEN = 6
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
        return Constants.NORMAL_ITEM_NAME + "_" + ItemType.ToString();
    }
    protected override string GetPrefabPath()
    {
        return Constants.PREFAB_NORMAL;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}

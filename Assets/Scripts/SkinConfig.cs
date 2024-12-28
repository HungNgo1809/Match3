using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinConfig", menuName = "ScriptableObjects/SkinConfig")]
public class SkinConfig : ScriptableObject
{
    public int curSkin; 
    public List<Skin> skins = new List<Skin>();
}
[System.Serializable]
public class Skin
{
    public List<Sprite> icons;
}

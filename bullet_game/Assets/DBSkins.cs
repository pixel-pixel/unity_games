using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkinSprite
{
    public bool _isBought;
    public int _priceSkin;
    public Sprite _skin;
}

[CreateAssetMenu]
public class DBSkins : ScriptableObject
{
    public SkinSprite[] scins;
    public int GetLenghts()
    {
        return scins.Length;
    }
    public SkinSprite GetBoyfrendSkin(int index)
    {
        return scins[index];
    }
}

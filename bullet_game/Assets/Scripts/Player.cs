using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DBSkins skins;
    private void Awake()
    {
        var skinIndex = PlayerPrefs.GetInt("activSkin");
        var sprite = skins.scins[skinIndex]._skin;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
}

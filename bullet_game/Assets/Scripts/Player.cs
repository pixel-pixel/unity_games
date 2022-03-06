using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DBSkins skins;
    public DBLevels levels;
    private Level _currentLevel;
    private Gun _gun;
    private Imposter[] _imposters;
    private void Awake()
    {
        var skinIndex = PlayerPrefs.GetInt("activSkin");
        var sprite = skins.scins[skinIndex]._skin;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    private void Start()
    {
        _currentLevel = levels.CurrentLevel();
        _gun = FindObjectOfType<Gun>();
        _imposters = FindObjectsOfType<Imposter>();

        _currentLevel.isFinished = false;
        _currentLevel.win = false;
    }

    public void Update()
    {
        if (_currentLevel.isFinished) return;
        
        if (_gun.countOfBullets == 0)
            StartCoroutine(Lost());

        if (_imposters.All(imp => imp.isDead))
            StartCoroutine(Won());
    }

    IEnumerator Won()
    {
        yield return new WaitForSeconds(3f);
        if (_currentLevel.isFinished) yield break;

        _currentLevel.isFinished = true;
        _currentLevel.win = true;
    }
    
    IEnumerator Lost()
    {
        yield return new WaitForSeconds(3f);
        if (_currentLevel.isFinished || _currentLevel.win) yield break;

        _currentLevel.isFinished = true;
        _currentLevel.win = false;
    }
}
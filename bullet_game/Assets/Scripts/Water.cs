using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Water : MonoBehaviour
{
    public float alpha;
    public GameObject waterDrops;

    private AudioSource _audio;
    void Start()
    {
        GetComponent<Tilemap>().color = new Color(1, 1, 1, alpha);
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var obj = collider.gameObject;
        if (obj.tag != "CollisionsMao")
        {
            Instantiate(waterDrops, obj.transform.position, Quaternion.identity);
            _audio.Play();
        }
    }
}

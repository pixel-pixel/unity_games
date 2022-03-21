using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletChecker : MonoBehaviour
{
    public GameObject miniBullet;
    
    private Gun _gun;
    private int _bulletCount;
    private List<GameObject> _bullets;
    private Vector3 _position;
    void Start()
    {
        _gun = (Gun)FindObjectOfType(typeof(Gun));
        _bulletCount = _gun.countOfBullets;
        _bullets = new();

        _position = transform.position + new Vector3(-0.75f, 0.00f);
        for (var i = 0; i < _bulletCount; i++)
        {
            _bullets.Add(Instantiate(miniBullet, _position, Quaternion.identity));
            _position += new Vector3(0.75f, 0);
        }
    }

    void Update()
    {
        if (_gun.countOfBullets < _bulletCount) RemoveBullet();
    }

    private void RemoveBullet()
    {
        Destroy(_bullets[^1]);
        _bullets.RemoveAt(_bullets.Count - 1);
        _bulletCount--;
    }
}

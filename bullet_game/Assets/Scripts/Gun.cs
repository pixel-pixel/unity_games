using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    private Rigidbody2D _gunRb;
    private GameObject _parent;
    private Vector2 _mousePosition;

    void Start()
    {
        _gunRb = GetComponent<Rigidbody2D>();
        _parent = transform.parent.gameObject;
    }

    void Update()
    {
        GunPositionToPlayer();
        GunAngleToMouse();

        if (Input.GetButtonDown("Fire1")) Fire();
    }

    private void GunPositionToPlayer()
    {
        transform.position = _parent.transform.position;
    }

    private void GunAngleToMouse()
    {
        _mousePosition = Camera.main!.ScreenToWorldPoint(Input.mousePosition);
        var posProb = _mousePosition - _gunRb.position;
        var angle = Mathf.Atan2(posProb.y, posProb.x) * Mathf.Rad2Deg;
        _gunRb.rotation = angle;
    }

    private void Fire()
    {
        var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        var bulletRd = bullet.GetComponent<Rigidbody2D>();
        
        bulletRd.AddForce(firePoint.right * bulletSpeed, ForceMode2D.Impulse);
    }
}
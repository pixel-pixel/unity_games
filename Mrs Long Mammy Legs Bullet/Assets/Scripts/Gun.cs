using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public int countOfBullets = 3;
    public DBLevels levels;

    private SpriteRenderer _renderer;
    private AudioSource _audio;
    private GameObject _player;
    private Vector2 _mousePosition;

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _audio = GetComponent<AudioSource>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        GunPositionToPlayer();

        if (
            Input.GetButtonDown("Fire1") &&
            countOfBullets > 0 &&
            !levels.CurrentLevel().isFinished
            )
        {
            GunAngleToMouse();
            StartCoroutine(Fire());
            countOfBullets--;
        }
    }

    private void GunPositionToPlayer()
    {
        transform.position = _player.transform.position;
    }

    private void GunAngleToMouse()
    {
        var mousePosition = Camera.main!.ScreenToWorldPoint(Input.mousePosition);
        
        var direction = mousePosition - transform.position;
        var angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3 (0, 0, angle);
    }

    private IEnumerator Fire()
    {
        var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Destroy(bullet, 3f);
        var bulletRd = bullet.GetComponent<Rigidbody2D>();

        bulletRd.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
        _audio.Play();

        enabled = false;
        _renderer.enabled = false;
        yield return new WaitForSeconds(3f);
        enabled = true;
        _renderer.enabled = true;
    }
}
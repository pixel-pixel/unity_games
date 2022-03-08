using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public int countOfBullets = 3;
    public DBLevels levels;

    private Rigidbody2D _gunRb;
    private AudioSource _audio;
    private GameObject _player;
    private Vector2 _mousePosition;

    void Start()
    {
        _gunRb = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        GunPositionToPlayer();
        GunAngleToMouse();

        if (
            Input.GetButtonDown("Fire1") &&
            countOfBullets > 0 &&
            !levels.CurrentLevel().isFinished
            )
        {
            Fire();
            countOfBullets--;
        }
    }

    private void GunPositionToPlayer()
    {
        transform.position = _player.transform.position + new Vector3(0, 0.00f);
    }

    private void GunAngleToMouse()
    {
        _mousePosition = Camera.main!.ScreenToWorldPoint(Input.mousePosition);
        var posProb = _mousePosition - _gunRb.position;
        var angle = Mathf.Atan2(posProb.y, posProb.x) * Mathf.Rad2Deg;
        GetComponent<SpriteRenderer>().flipY = angle > 90;
        _gunRb.rotation = angle;
    }

    private void Fire()
    {
        var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        var bulletRd = bullet.GetComponent<Rigidbody2D>();

        bulletRd.AddForce(firePoint.right * bulletSpeed, ForceMode2D.Impulse);
        _audio.Play();
    }
}
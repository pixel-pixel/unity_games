using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private AudioSource _audio;
    private Vector3 _lastVelocity;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        _lastVelocity = _rigidbody.velocity;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        var speed = _lastVelocity.magnitude;
        var direction = Vector3.Reflect(_lastVelocity.normalized, col.contacts[0].normal);

        _rigidbody.velocity = direction * Mathf.Max(speed, 3f);
        _audio.Play();
    }
}

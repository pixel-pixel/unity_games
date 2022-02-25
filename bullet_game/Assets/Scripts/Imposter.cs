using System;
using UnityEngine;

public class Imposter : MonoBehaviour
{
    public GameObject blood;
    
    private Animator _animator;
    private AudioSource _audio;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" && !_animator.GetBool("isDead"))
        {
            _animator.SetBool("isDead", true);
            Instantiate(blood, transform.position, Quaternion.identity);
            _audio.Play();
        }
    }
}

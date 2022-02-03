using System;
using UnityEngine;

public class ImposterScript : MonoBehaviour
{
    public GameObject blood;
    private Animator _animator;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" && !_animator.GetBool("isDead"))
        {
            _animator.SetBool("isDead", true);
            Instantiate(blood, transform.position, Quaternion.identity);
            
        }
    }
}

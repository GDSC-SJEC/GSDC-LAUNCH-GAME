using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool _canJump = true;
    [SerializeField]
    AudioSource _jumpSound;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void JumpCharacter()
    {
        if (_canJump && rb.velocity == new Vector2(0,0))
        {
            _canJump = false;
            rb.AddForce(Vector2.up * 5500); //5000
            _jumpSound.Play();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boundary") return;


        _canJump = true;
        transform.parent = collision.gameObject.transform;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boundary") return;
        transform.parent = null;
    }
}

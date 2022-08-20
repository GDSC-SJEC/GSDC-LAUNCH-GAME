using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool _canJump = true;

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
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        _canJump = true;
        transform.parent = collision.gameObject.transform;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        transform.parent = null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]
    float Xwidth;

    [SerializeField]
    int speed;
    private bool movingLeft;
    Jump player;

    void Start()
    {
        movingLeft = true;
        FindObjectOfType<Jump>();
    }

    void Update()
    {
        if (movingLeft == true)
        {
            // move left
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x <= -Xwidth) movingLeft = false;
        }
        else
        {
            // move right
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= Xwidth) movingLeft = true;
        }
    }

    
}

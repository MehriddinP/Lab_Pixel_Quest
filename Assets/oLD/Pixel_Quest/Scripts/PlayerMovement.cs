using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriterenderer;
    public int speed = 4;

    // Start is called before the first frame update
    void Start()
    {
       _rigidbody2D = GetComponent<Rigidbody2D>();
       _spriterenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0) { _spriterenderer.flipX = true; }
        if(horizontal < 0) { _spriterenderer.flipX = false; }

        _rigidbody2D.velocity = new Vector2(horizontal *  speed, _rigidbody2D.velocity.y);
    }
}

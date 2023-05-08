using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float movement;
    [SerializeField] float movementup;
    [SerializeField] int speed = 10;
    [SerializeField] public bool isFacingRight;

    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        movementup = Input.GetAxis("Vertical");      
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(rigid.velocity.x, movementup * speed);
        rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);
        if ((movement < 0 && isFacingRight) || (movement > 0 && !isFacingRight))
            Flip();
       
    }
    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
   
}

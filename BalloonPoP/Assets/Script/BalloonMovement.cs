using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonmovement : MonoBehaviour
{
    [SerializeField] float maxSpeed = 6f;
    [SerializeField] Rigidbody2D rigid;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   //random movement
        movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        if (transform.position.x > 13)
        {
            movement = new Vector2(0, 0);
            movement = new Vector2(-1f, 0);

        }
        if (transform.position.x < -13)
        {
            movement = new Vector2(0, 0);
            movement = new Vector2(1f, 0);
        }
        if (transform.position.y > 6)
        {
            movement = new Vector2(0, 0);
            movement = new Vector2(0, -1f);
        }
        if (transform.position.y < -6)
        {
            movement = new Vector2(0, 0);
            movement = new Vector2(0, 1f);
        }
    }
    void FixedUpdate()
    {
        rigid.AddForce(movement * maxSpeed);
    }

}

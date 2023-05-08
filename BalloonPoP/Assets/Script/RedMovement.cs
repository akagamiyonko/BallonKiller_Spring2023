using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmovement : MonoBehaviour
{
    [SerializeField] float maxSpeed = 6f;
    Vector2 movement;
    [SerializeField] Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(0, -3f);
        if (transform.position.y < -2)
        {
            movement = new Vector2(0, 3f);
        }
        if (transform.position.y > 6)
        {                                                                                                                                               
            movement = new Vector2(0, -3f);
        }
    }
    void FixedUpdate()
    {
        rigid.AddForce(movement * maxSpeed);
    }
}

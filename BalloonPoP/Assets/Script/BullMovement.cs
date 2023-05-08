using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullmovement : MonoBehaviour
{
     [SerializeField] float maxSpeed = 3f;
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
         movement = new Vector2(-0.5f, 0f);

          if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
     void FixedUpdate()
    {
        rigid.AddForce(movement * maxSpeed);
    }
}

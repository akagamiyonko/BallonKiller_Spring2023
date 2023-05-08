using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if ((other.gameObject.CompareTag("balloon")))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);

        if ((other.gameObject.CompareTag("Red")))
        {
            Destroy(gameObject);
        }
        if ((other.gameObject.CompareTag("Bull")))
        {
            Destroy(gameObject);
        }
         
    }
    void FixedUpdate()
    {
        Destroy(gameObject,1);
    }
}

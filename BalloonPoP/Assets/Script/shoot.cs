using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shoot : MonoBehaviour
{
    GameObject playerObj = null;
    [SerializeField] GameObject pinPrefab;
    [SerializeField] float fireRate = 1;
    float lastShot = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            spawn();
        }
        
    }
    void spawn()
    {

        if (Time.time > fireRate + lastShot) {
            float x = playerObj.transform.position.x;
            float y = playerObj.transform.position.y;


            Vector2 position = new Vector2(x, y);
            GameObject new_pin = Instantiate(pinPrefab, position, Quaternion.identity);
            new_pin.transform.right = transform.right.normalized; // code to transform pin to direction of player
            lastShot = Time.time;

        }

    }

}

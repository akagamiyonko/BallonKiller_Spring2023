using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBalloon : MonoBehaviour
{

    [SerializeField] GameObject controller;
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.CompareTag("pin")))
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            score();
        }
    }
    void score()
    {
        controller.GetComponent<Score>().AddPoints(-1);
    }
}


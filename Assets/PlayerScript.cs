using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 6;

    private float screenHalfWidthInWorldUnits;

    void Start()
    {
        float halfPlayerWidth = transform.localScale.x/2f;
        screenHalfWidthInWorldUnits = (Camera.main.aspect * Camera.main.orthographicSize) + halfPlayerWidth;
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        float velocity = input * speed;
        transform.Translate(Vector2.right * (velocity * Time.deltaTime));
        if (transform.position.x < -screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(screenHalfWidthInWorldUnits, transform.position.y);
        }
        if (transform.position.x > screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(-screenHalfWidthInWorldUnits, transform.position.y);
        }
    }

    void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Block")
        {
            //Destroy(gameObject);
            GameOver();
        }
    }

    void GameOver()
    {
        print("You Died");
    }
}

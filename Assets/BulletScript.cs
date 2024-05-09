using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float topOfScreen;
    public float speed = 7;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        topOfScreen = (Camera.main.aspect) * Camera.main.orthographicSize;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
        if (transform.position.y > topOfScreen)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Block")
        {
            logic.AddScore();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    private float bottomOfScreen;
    public float speed = 7;

    // Start is called before the first frame update
    void Start()
    {
        bottomOfScreen = -1/(Camera.main.aspect) * Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * (speed * Time.deltaTime));
        if (transform.position.y < bottomOfScreen)
        {
            Destroy(gameObject);
        }
    }
}

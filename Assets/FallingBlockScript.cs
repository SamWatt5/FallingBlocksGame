using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float spawnHeight = 1/(Camera.main.aspect) * Camera.main.orthographicSize;
        if (transform.position.y < -spawnHeight)
        {
            Destroy(gameObject);
        }
    }
}

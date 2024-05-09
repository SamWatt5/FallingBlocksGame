using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BulletSpawnerScript : MonoBehaviour
{
    public GameObject particlePrefab;
    private GameObject player;

    public float spawnRate = 0.05f;
    private float nextSpawnTime;

    public float speedOfParticle;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //if (Time.time > nextSpawnTime)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //nextSpawnTime = Time.time + spawnRate;

            Vector2 newParticlePosition = new Vector2(player.transform.position.x, player.transform.position.y + 0.5f);

            Instantiate(particlePrefab, newParticlePosition, quaternion.identity);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SmokeSpawnerScript : MonoBehaviour
{
    public GameObject particlePrefab;
    private GameObject player;

    public float spawnRateMin = 0.02f;
    public float spawnRateMax = 0.075f;
    private float nextSpawnTime;

    public float sizeMin = 0.05f;
    public float sizeMax = 0.2f;

    public float speedOfParticle;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float spawnRate = Random.Range(spawnRateMin, spawnRateMax);
            nextSpawnTime = Time.time + spawnRate;

            Vector2 newParticlePosition = new Vector2(player.transform.position.x, player.transform.position.y - 0.5f);
            Vector3 rotation = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            GameObject newParticle = Instantiate(particlePrefab, newParticlePosition, quaternion.identity);

            float randSize = Random.Range(sizeMin, sizeMax);
            newParticle.transform.localScale = Vector3.one * randSize;

        }
    }
}

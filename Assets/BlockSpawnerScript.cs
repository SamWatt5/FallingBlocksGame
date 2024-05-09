using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockSpawnerScript : MonoBehaviour
{
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 1;
    private float nextSpawnTime;

    public GameObject blockPrefab;

    private float screenHalfWidthInWorldUnits;
    private float spawnHeight;
    // Start is called before the first frame update
    void Start()
    {
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
        spawnHeight = 1/(Camera.main.aspect) * Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawnTime)
        {
            float spawnRate = Random.Range(spawnRateMin, spawnRateMax);
            nextSpawnTime = Time.time + spawnRate;
            Vector2 newBlockPosition =
                new Vector2(Random.Range(-screenHalfWidthInWorldUnits, screenHalfWidthInWorldUnits), spawnHeight);
            // Vector3 rotation = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            // GameObject newBlock = Instantiate(blockPrefab, newBlockPosition, quaternion.Euler((rotation)));
            GameObject newBlock = Instantiate(blockPrefab, newBlockPosition, quaternion.identity);
            // float randSize = Random.Range(0.75f, 1.25f);
            // newBlock.transform.localScale = Vector3.one * randSize;
        }

    }
}

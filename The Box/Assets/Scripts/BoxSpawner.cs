using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    private float nextSpawnTime;
    GameObject boxInstance;

    [SerializeField] private GameObject box;
    [SerializeField] private float spawnDelay = 10;
    [SerializeField] float boxLife = 3.0f;

    private void Update() {
        if (ShouldSpawn()) {
            Spawn();
        }

        Delete();
    }

    private void Delete() {
        Destroy(this.boxInstance, boxLife);
    }

    private void Spawn() {
        nextSpawnTime = Time.time + spawnDelay;
        boxInstance = Instantiate(box, transform.position, transform.rotation);
    }

    private bool ShouldSpawn() {
        return Time.time >= nextSpawnTime;
    }
   
}

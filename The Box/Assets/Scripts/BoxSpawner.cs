using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{

    [SerializeField] private GameObject box;

    public GameObject boxInstance;
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 3.0f;
 
    private float timer = 0.0f;
    private float nextTime;
         
    void Start () {
        nextTime = Random.Range(minSpawnTime, maxSpawnTime);    
    }
     
    void Update () {
        timer += Time.deltaTime;
         
        if (timer > nextTime) {
            Vector3 pos = new Vector3(0.0f, 12.84f, Random.value);
 
            Instantiate(box, pos, Quaternion.identity);
             
            Debug.Log("Object created");
             
            timer = 0.0f;
            nextTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
   
}

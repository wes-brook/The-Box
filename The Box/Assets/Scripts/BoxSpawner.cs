using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    // Declare boundary objects
    public GameObject leftBar;
    public GameObject rightBar;

    [SerializeField] private GameObject box;

    // Declare arbitrary range between box instances
    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 3.0f;
 
    private float timer = 0.0f;
    private float nextTime;
         
    void Start () 
    {
        nextTime = Random.Range(minSpawnTime, maxSpawnTime);    
        
        leftBar = GameObject.Find("BarrierLeft");
        rightBar = GameObject.Find("BarrierRight");
    }
     
    void FixedUpdate () 
    {
        timer += Time.deltaTime;
         
        if (timer > nextTime) {
            Vector3 pos = new Vector3(0.0f, gameObject.transform.position.y, boxSpawnerRange());
 
            Instantiate(box, pos, Quaternion.identity);
             
            Debug.Log("Object created");
             
            timer = 0.0f;
            nextTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    // Generates a float value between the left and right barriers
    float boxSpawnerRange() 
    {
        return Random.Range(leftBar.transform.position.z, rightBar.transform.position.z);
    }
   
}

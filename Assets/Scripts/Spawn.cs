using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs; 
    public float obstacleSpawnTime = 1; 
    public float obstacleSpeed = 3; 
    private float  timeUntilSpawn; 
    private void Start(){
        //obstacleSpawnTime = Random.Range(0,5);
    }
    

    private void Update(){
        
        SpawnLoop(); 
    }

    private void SpawnLoop(){
        timeUntilSpawn += Time.deltaTime; 

        if(timeUntilSpawn >= obstacleSpawnTime){
            SpawnIt();
            timeUntilSpawn = 0f; 
        }
    }
    
    private void SpawnIt(){
        GameObject obstacleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        GameObject spawnedObstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity); 
        obstacleSpawnTime = Random.Range(0.0f,2.0f); 
        spawnedObstacle.transform.localScale += new Vector3(0f, Random.Range(-0.5f, 0.5f), 0);
        
        Rigidbody2D obstacleRB = spawnedObstacle.GetComponent<Rigidbody2D>(); 
        obstacleRB.velocity = Vector2.left * obstacleSpeed; 
    
    
    }

}

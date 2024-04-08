using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] refabs; 
    public float obstacleSpawnTime = 4; 
    public float obstacleSpeed = 3; 
    private float  timeUntilSpawn; 
    public float x = 7; 
    public float y = 3; 
    public float z = 0.2f; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
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
    public void Updating(float a, float b, float c){
        x = a; 
        y = b; 
        z = c; 
    }
    public float getX(){
        return x; 
    }
    public float getY(){
        return y; 
    }
    public float getZ(){
        return z; 
    }
    private void SpawnIt(){

        GameObject obstacleToSpawn = refabs[Random.Range(0, refabs.Length)];
        GameObject spawnedObstacle = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity); 
        obstacleSpawnTime = Random.Range(x,y); 
        spawnedObstacle.transform.localScale += new Vector3(0f, Random.Range(-0.5f, z), 0);
        
        Rigidbody2D obstacleRB = spawnedObstacle.GetComponent<Rigidbody2D>(); 
        obstacleRB.velocity = Vector2.left * obstacleSpeed; 
    
    
    }


}

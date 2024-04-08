using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; 
    public Spawn sp;
    public Hook ho;
    
    
   // private script Timer

    // Update is called once per frame
    void Start(){
        //GameObject.Find("TimeCanvas").Start(); 
        //sp = new Spawn(); 
        //ho = transform.Find("HookSpawm");
    }
    void LateUpdate() //generally considered best practice to do Camera Movement after 
    {
        if(target == null) return; 
        transform.position = new Vector3(target.position.x, 
                transform.position.y, transform.position.z); 
    }

    public void SpeedUp(){
        
        sp.GetComponent<Spawn>().obstacleSpeed += 1; 
        
        sp.GetComponent<Spawn>().obstacleSpawnTime -= 0.2f; 
        Debug.Log("Speed");

        GetComponent<Hook>().obstacleSpeed += 1; 
        Debug.Log("Speed1.2");
        GetComponent<Hook>().obstacleSpawnTime -= 0.2f; 
        
        Debug.Log("Speed2");

        if(ho.GetComponent<Hook>().getX() !=0){
           if(ho.GetComponent<Hook>().getY() != 0){
               if(ho.GetComponent<Hook>().getZ() < 0.5){
                   ho.GetComponent<Hook>().Updating(ho.GetComponent<Hook>().getX()-1f, ho.GetComponent<Hook>().getY()-1f, ho.GetComponent<Hook>().getZ()+0.2f);
               }
               ho.GetComponent<Hook>().Updating(ho.GetComponent<Hook>().getX()-1f, ho.GetComponent<Hook>().getY()-1f, ho.GetComponent<Hook>().getZ());
           }
           ho.GetComponent<Hook>().Updating(ho.GetComponent<Hook>().getX()-1f, ho.GetComponent<Hook>().getY(), ho.GetComponent<Hook>().getZ());
        }
        
        
        
        
    }
}

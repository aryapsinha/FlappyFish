using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0; 
    public float switchTime = 2;
    void Start()
    {
       // GetComponent<Rigidbody2D>().velocity = Vector2.up * speed; 
       // InvokeRepeating("Switch", 0, switchTime); 
    }

    // Update is called once per frame
    void Switch()
    {
       // GetComponent<Rigidbody2D>().velocity *= -1; 
    }
}

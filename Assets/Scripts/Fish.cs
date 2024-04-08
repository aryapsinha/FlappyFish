using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6;
    public float force = 400; 
    public SpriteRenderer spriteRenderer; 
    public Animator animator; 
    public Sprite dead; 
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed; 
        animator.enabled = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force); 
    }

    void OnCollisionEnter2D(Collision2D coll){
        spriteRenderer.sprite = dead;
        transform.localScale = new Vector3(0.7f, 0.7f, 1f);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + 180, transform.eulerAngles.y, transform.eulerAngles.z);
        animator.enabled = false; 
        Debug.Log("ran");
        
        SceneManager.LoadScene("Lose"); 
        //when it collides, restart the scene
    }
}

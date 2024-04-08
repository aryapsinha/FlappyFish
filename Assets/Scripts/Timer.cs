using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using System; 

public class Timer : MonoBehaviour
{
    private bool active; 
    private float currentTime; 
    [SerializeField] private TMP_Text text; 
    [SerializeField] private TMP_Text besttext; 
    public CameraFollow cam; 
    public double best = 0.0; 
    
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInParent<CameraFollow>(); 
        currentTime = 0; 
        active = true; 
        if(PlayerPrefs.HasKey("bestTime")){
            best = double.Parse(PlayerPrefs.GetString("bestTime"));
        }
        besttext.text = ((int)(best/60))%60 + ":" + (best%60); 
    

    }

    // Update is called once per frame
    void Update()
    {
        if(active){
            currentTime = currentTime + Time.deltaTime; 
        }
        
        TimeSpan time = TimeSpan.FromSeconds(currentTime); 
        text.text = time.Minutes.ToString() + ":" + time.Seconds.ToString() + ":" + time.Milliseconds.ToString();
        if(time.Seconds % 30 == 0 && time.Milliseconds % 999 == 0){
            cam.SpeedUp(); 
           // Debug.Log("pop");
        }
        if(time.TotalSeconds > best){
            best = time.TotalSeconds; 
            PlayerPrefs.SetString("bestTime", best.ToString());
        }
        
        
    }
    public void StartTimer(){
        active = true; 
    }
    public void StopTimer(){
        active = false; 
    }
}

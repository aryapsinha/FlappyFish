using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
   /* public StartScript s; 
    void Start()
    {
        StartScript bt = s.GetComponent<StartScript>(); 
        bt.onClick.AddListener(SceneChange);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    */
    public void SceneChange(){
        SceneManager.LoadScene("SampleScene"); 
    }

}

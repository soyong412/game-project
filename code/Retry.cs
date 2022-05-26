using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public static int ry;
    // Start is called before the first frame update
    void Start()
    {
   
      
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeGameScene()
    {
        ry = 1;
 
        SceneManager.LoadScene("maingame");


    }

}

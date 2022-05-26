using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Quit;
    public GameObject GameTimeS;
    public GameObject cs;


    void Start()
    {
        Quit.SetActive(false);
        Panel1.SetActive(false);
        
     
      
    }

   
    void Update()
    {
        
    }

    public void PauseButton()
    {
        Panel1.SetActive(true);
        Time.timeScale = 0;
        GameTimeS.SetActive(false);
        cs.SetActive(false);
        
    }



    public void Continue()
    {
        GameTimeS.SetActive(true);
        cs.SetActive(true);
        Panel1.SetActive(false);
        Time.timeScale = 1;
        
    }
    
    public void SoundMu()
    {
        AudioListener.volume = 0;
    }

    public void SoundOn()
    {
        AudioListener.volume = 1;

    }

    public void QuitButton()
    {
        Quit.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public int SaveScore;
    public Text TextHt;
   // public GameObject Panel1;
    //public GameObject GameTimeS;
    


    void Awake()
    {
        score = 0;

    }

    void Start()
    {
        
    }
    void Update()
    {

       
         if (PlayerPrefs.GetInt("HighScore") == 0) //최고기록 0점일때
         {

             PlayerPrefs.SetInt("HighScore", score);
             SaveScore = PlayerPrefs.GetInt("HighScore");
             PlayerPrefs.Save();
             Debug.Log(PlayerPrefs.GetInt("HighScore"));

         }
         else if (PlayerPrefs.GetInt("HighScore") < score) //최고기록 넘었을때
         {
             PlayerPrefs.SetInt("HighScore", score);
             SaveScore = PlayerPrefs.GetInt("HighScore");
             PlayerPrefs.Save();
             Debug.Log(PlayerPrefs.GetInt("HighScore"));
         }
         else if (PlayerPrefs.GetInt("HighScore") > score) //최고기록 못넘었을때
         {

             SaveScore = PlayerPrefs.GetInt("HighScore");
             Debug.Log(PlayerPrefs.GetInt("HighScore"));

         }


         TextHt.text = (PlayerPrefs.GetInt("HighScore")).ToString("0") + "점";
        
        //PlayerPrefs.DeleteAll();
    }
   
}


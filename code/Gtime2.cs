using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gtime2 : MonoBehaviour
{
    GameOver gameover;
    private float Second1;
    private float Minute1;
    public GameObject EndPanel;
    public Text GameTimeText1;
    public float GameTime1;
    //public float GameOverTime;
 


    void Start()
    {
      

    }
    void Update()
    {
        if (EndPanel.activeSelf == false)
        {
            GameTime1 += Time.deltaTime;
            Second1 = (int)GameTime1 % 60;
            Minute1 = (int)GameTime1 / 60;

            


        }
        else if(EndPanel.activeSelf == true)
        {

            GameTimeText1.text = Minute1.ToString("0") + " 분 " + Second1.ToString("0") + " 초 ";
        }

            
        

    }



}
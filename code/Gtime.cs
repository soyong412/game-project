using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gtime : MonoBehaviour
{
    GameOver gameover;
    private float Second;
    private float Minute;
    public GameObject EndPanel;
    public Text GameTimeText;
    public float GameTime;
    public float GameOverTime;
    public float GameOver_Second;
    public float GameOver_Minute;
    //public Text GameOverTimeText;

    void Start()
    {
       
        //EndPanel.gameObject.SetActive(false);

    }
    void Update()
    {
        if (EndPanel.activeSelf == false)
        {
            GameTime += Time.deltaTime;
            Second = (int)GameTime % 60;
            Minute = (int)GameTime / 60;

            GameTimeText.text = Minute.ToString("0") + " 분 " + Second.ToString("0") + " 초 ";


        }
        else if(EndPanel.activeSelf == true)
        {

            GameOverTime = GameTime;
            GameOver_Second = (int)GameOverTime % 60;
            GameOver_Minute = (int)GameOverTime / 60;

           // GameOverTimeText.text = GameOver_Minute + GameOver_Second;
        }

            
        

    }



}







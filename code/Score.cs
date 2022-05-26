using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score=0;
    private Text TextScore;
    private Rigidbody2D rd;
    private Player script;
    public GameObject EndPanel;
    public GameObject cs;

   

    void Start()
    {

        rd = GetComponent<Rigidbody2D>();

       
    }

    private void Awake()
    {

    

        TextScore = GetComponent<Text>();

        



    }


    void Update()
    {
       




        TextScore.text = ScoreManager.score.ToString();
       



        void OnCollisionEnter2D(Collision2D other)
        {

            if (other.gameObject.tag == "food")
            {


                Debug.Log("eat count");

                score += 1;
                

                script = GameObject.Find("정면").GetComponent<Player>();


            }
        }


        if (EndPanel.gameObject.activeSelf == true)
        {
            cs.gameObject.SetActive(false);
        }
    }
}

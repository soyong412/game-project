using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string SampleScene; 
    public GameObject EndPanel;
    public GameObject GameTimeS;
    public Text GameOverTimeText;


    void Start()
    {
        EndPanel.gameObject.SetActive(false);
        

    }
    public void Show()
    {
   
        EndPanel.gameObject.SetActive(true);
        //text(점수 표시할 text오브젝트의 이름)= 
    }

    // Update is called once per frame
    void Update()
    {
        if(EndPanel.activeSelf==true)
        {
           
           GameTimeS.SetActive(false);



        }
    }




}

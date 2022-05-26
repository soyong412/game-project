using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Quit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Yes()
    {
        Application.Quit();
    }

    public void No()
    {
        Quit.SetActive(false);
        Panel1.SetActive(true);
    }
}

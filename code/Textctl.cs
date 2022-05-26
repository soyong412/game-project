using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textctl : MonoBehaviour
{
    public float DestroyTime = 2.0f;
    public GameObject Text;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

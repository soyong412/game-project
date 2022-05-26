
using Debug = UnityEngine.Debug;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
   
{
    public Animator anim;
    public float speed;
    Rigidbody2D rigid;
    public Joystick joystick;
    public GameObject Jelly1;
    public GameObject Jelly2;
    public GameObject Jelly3;
    public GameObject Jelly4;
    public GameObject Jelly5;
    public GameObject EndPanel;

    //젤리 추가 코드
    int score = 0;
    public Text TextScore;

    public void Start()
    {
        anim = GetComponent<Animator>();
      
    }

    void Awake()
    {
        joystick = GameObject.FindObjectOfType<Joystick>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            MoveControl();
        }
    }

    public void MoveControl()
    {
        Vector3 upMovement = Vector3.up * speed * Time.deltaTime * joystick.Vertical;
        
 
        Vector3 rightMovement = Vector3.right * speed * Time.deltaTime * joystick.Horizontal;

        transform.position += upMovement;
        transform.position += rightMovement;
    }
    ///코드추가///// 젤리에 닿으면 사라지기, 젤리 먹은 개수 누적////
    private void OnCollisionEnter2D(Collision2D col)
    {
        

        if (col.gameObject.tag== "food")
        {
            if (col.gameObject.activeSelf == false)
            {
               ScoreManager.score = ScoreManager.score;
            }
          
            col.gameObject.SetActive(false);
            ScoreManager.score += 1;
            //if (col.gameObject.activeSelf == false)
            // {

            // }
            //Destroy(col.gameObject);
            //ScoreManager.score += 1;
            JellyF();
            
         
            GameOver();
        }
            
    }
    

    void JellyF()
    {
       
        if (Jelly1.activeSelf==false)
        {
            Invoke("JellyT1", Random.Range(1.5f, 5.0f));
        }
         if (Jelly2.activeSelf == false)
        {
            Invoke("JellyT2", Random.Range(1.5f, 3.0f));
        }
         if (Jelly3.activeSelf == false)
        {
            Invoke("JellyT3", Random.Range(1.5f, 7.0f));
        }
        if (Jelly4.activeSelf == false)
        {
            Invoke("JellyT4", Random.Range(1.5f, 4.0f));
        }
        if (Jelly5.activeSelf == false)
        {
            Invoke("JellyT5", Random.Range(1.5f, 3.0f));
        }
   

        
    }

    void JellyT1()
    {
        Jelly1.SetActive(true);
    }
    void JellyT2()
    {
        Jelly2.SetActive(true);
    }
    void JellyT3()
    {
        Jelly3.SetActive(true);
    }
    void JellyT4()
    {
        Jelly4.SetActive(true);
    }
    void JellyT5()
    {
        Jelly5.SetActive(true);
    }










    public void GameOver()
    {
       // Debug.Log("GameOver");
      //  Destroy(gameObject);  //
    }

    public void Update()
    {
////////////////////////////////
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.02f) pos.x = 0.02f;
        if (pos.x > 0.98f) pos.x = 0.98f;
        if (pos.y < 0.07f) pos.y = 0.07f;
        if (pos.y > 0.93f) pos.y = 0.95f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
//////////////////////////////////////
        anim.SetFloat("cat left", 0);
        anim.SetFloat("cat right", 0);
        anim.SetFloat("walk", 1.1f);

        if (joystick.input.x < 0)
        {

            anim.SetFloat("cat left", 3.2f);
            anim.SetFloat("cat right", 0);
            anim.SetFloat("walk", 0);
        }


        else if (joystick.input.x >0) 
        { 
            anim.SetFloat("cat right", 5.5f);
            anim.SetFloat("cat left", 0);
            anim.SetFloat("walk", 0);

        }

        else
        {
            anim.SetFloat("walk", 1.1f);
            anim.SetFloat("cat left", 0);
            anim.SetFloat("cat right", 0);
        }



        if (EndPanel.gameObject.activeSelf == true)
        {
            Destroy(gameObject);
        }


    }


}

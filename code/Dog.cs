using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dog : MonoBehaviour
{
    private GameOver script; //gameover 코드 추가
    public Transform target;
    private Rigidbody2D rigid2D;
    float timer;
    public Animator anim;
    //    int waitingTime;


    //gameover 코드 추가

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Cat")
        {
            //Debug.Log("GameOver");
            moveSpeed = 0;
            //"정면"오브젝트에 연결된 Player 스크립트를 가져온다
            //비활성화한 오브젝트는 GameObject.Find로 불러올 수 없어서
            //그보다 상위 오브젝트인 canvas를 먼저 불러오고 자식 오브젝트인 endpanel을 불러온다
            script = GameObject.Find("Canvas").transform.Find("EndPanel").GetComponent<GameOver>();
            //스크립트의 함수를 호출한다.
            script.Show();


        }
    }




    [Header("추격속도")]
    [SerializeField] [Range(1f, 4f)] float moveSpeed = 3f;

    [Header("딜레이시간")]
    [SerializeField] [Range(0, 4)] float waitingTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        timer = 0;

        //gameover 코드 추가
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.02f) pos.x = 0.02f;
        if (pos.x > 0.98f) pos.x = 0.98f;
        if (pos.y < 0.07f) pos.y = 0.07f;
        if (pos.y > 0.93f) pos.y = 0.95f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        //코드 추가가가가가가       

        anim.SetFloat("dog left", 0);
        anim.SetFloat("dog right", 0);
        anim.SetFloat("dog walk", 1.1f);


        if (target.position.x < transform.position.x) //
        {
            anim.SetFloat("dog left", 3.2f);
            anim.SetFloat("dog right", 0);
            anim.SetFloat("dog walk", 0);
        }

        else if (target.position.x > transform.position.x)//
        {
            anim.SetFloat("dog left", 0);
            anim.SetFloat("dog right", 5.5f);
            anim.SetFloat("dog walk", 0);
        }
        else
        {
            anim.SetFloat("dog left", 0);
            anim.SetFloat("dog right", 0);
            anim.SetFloat("dog walk", 1.1f);
        }




    }
    void FollowTarget()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }

        // if(target.position)

    }
}
   



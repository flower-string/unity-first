using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //角色移动速度
    public float speed;
    private Rigidbody player;
    private Animator animator;
    private bool isA;
    private bool isD;
    private float countdowntime;
    private bool isonground;
    private Vector3 my_jump;
    // Start is called before the first frame update
    void Start()
    {
        isonground = true;
        speed = 5;
        my_jump = new Vector3(0, speed * 2, 0);
        //获取玩家控制组件
        player = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    public void setspeed(float ss)
    {
        speed = ss;
        my_jump = new Vector3(0, speed * 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            isA = true;
            animator.SetBool("begin", true);
            transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            isA = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            isD = true;
            animator.SetBool("begin", true);
            transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            isD = false;
        }
        if(isA==false&&isD==false)
        {
            animator.SetBool("begin", false);
        }
        if (player.velocity == Vector3.zero && Input.GetKey(KeyCode.W))
        {
            if (isonground == true)
            {
                animator.SetTrigger("jump");
                player.velocity = my_jump;
                isonground = false;
            }
        }
        if(isonground == false)
        {
            countdowntime -= Time.deltaTime;
            if(countdowntime <= 0f)
            {
                isonground=true;
                countdowntime = 0.3f;
            }
        }
    }
}

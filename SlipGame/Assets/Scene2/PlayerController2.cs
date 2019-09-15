using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    GameObject TextManager;
    CountManager2 count_script;
    Animator animator;
    Rigidbody2D rb;
    public int moveSpeed = 200;
    bool stop = false;
    int[] v_x = new int[5] { 1, 0, -1, 0, 0 };
    int[] v_y = new int[5] { 0, 1, 0, -1, 0 };
    public int v_direction;
    public bool selected_flg = true;

    void Start()
    {
        TextManager = GameObject.Find("TextManager");
        count_script = TextManager.GetComponent<CountManager2>();
        // 初期化
        // コントローラをセットしたオブジェクトに紐付いている
        // Animatorを取得する
        this.animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
        //   Debug.Log(rb.velocity.y);
        v_direction = 4;
        // 衝突時にobjectを回転させない設定
        this.rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        //Playerの初期画像
        animator.SetFloat("x", 0);
        animator.SetFloat("y", -1);
    }

    void FixedUpdate()
    {

        if (v_direction == 4 && selected_flg == true)
        {
            animator.speed = 1.0f;
            this.rb.constraints = RigidbodyConstraints2D.None;
            this.rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                v_direction = 0;
                animator.SetFloat("x", 1);
                animator.SetFloat("y", 0);
                count_script.CountAdd();
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                v_direction = 1;
                animator.SetFloat("x", 0);
                animator.SetFloat("y", 1);
                count_script.CountAdd();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                v_direction = 2;
                animator.SetFloat("x", -1);
                animator.SetFloat("y", 0);
                count_script.CountAdd();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                v_direction = 3;
                animator.SetFloat("x", 0);
                animator.SetFloat("y", -1);
                count_script.CountAdd();
            }

            //    Debug.Log(v_direction);
        }
        else if (v_direction == 4 && selected_flg == false)
        {
            animator.speed = 0.0f;
            this.rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }


        //キャラ移動
        rb.velocity = new Vector2(v_x[v_direction] * moveSpeed, v_y[v_direction] * moveSpeed);

    }



    void OnCollisionEnter2D(Collision2D col)
    { //2Dの衝突判定
        if (col.gameObject.tag == "Wall")
        {   //Wallタグのついたオブジェクトと衝突時
            MassInn(21.0f);
            //   Debug.Log("Wall");
        }
        else if (col.gameObject.tag == "Player" && v_direction != 4)
        {
            MassInn(30.0f);
        }
    }

    void MassInn(float move_length)
    {
        Vector3 pos = transform.position;
        if (v_direction == 0)
        {
            pos.x += -move_length;
        }
        else if (v_direction == 1)
        {
            pos.y += -move_length;
        }
        else if (v_direction == 2)
        {
            pos.x += move_length;
        }
        else if (v_direction == 3)
        {
            pos.y += move_length;
        }
        transform.position = pos;

        v_direction = 4;
    }

    public void ChangeFalse()
    {
        selected_flg = false;
    }

    public void ChangeTrue()
    {
        selected_flg = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager3 : MonoBehaviour
{
    GameObject clickedGameObject;

    GameObject Player_1; //キャラクターのオブジェクトそのものが入る変数
    GameObject Player_2;
    GameObject Player_3;
    GameObject Player_4;

    PlayerController3 script_1; //PlayerController3が入る変数
    PlayerController3 script_2;
    PlayerController3 script_3;
    PlayerController3 script_4;

    private bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        Player_1 = GameObject.Find("Player_1");
        Player_2 = GameObject.Find("Player_2");
        Player_3 = GameObject.Find("Player_3");
        Player_4 = GameObject.Find("Player_4");
        script_1 = Player_1.GetComponent<PlayerController3>();
        script_2 = Player_2.GetComponent<PlayerController3>();
        script_3 = Player_3.GetComponent<PlayerController3>();
        script_4 = Player_4.GetComponent<PlayerController3>();

        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isPlaying == true)
        {
            //クリックしたキャラを動かす
            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
            }
            if (script_1.v_direction == 4 && script_2.v_direction == 4)
            {
                if (clickedGameObject.name == "Player_1")
                {
                    Debug.Log(clickedGameObject);
                    //        hit2d.collider.gameObject.GetComponent<MoveTest>().selected_flg = true;
                    script_1.ChangeTrue();
                    script_2.ChangeFalse();
                    script_3.ChangeFalse();
                    script_4.ChangeFalse();
                }
                else if (clickedGameObject.name == "Player_2")
                {
                    script_1.ChangeFalse();
                    script_2.ChangeTrue();
                    script_3.ChangeFalse();
                    script_4.ChangeFalse();
                }
                else if (clickedGameObject.name == "Player_3")
                {
                    script_1.ChangeFalse();
                    script_2.ChangeFalse();
                    script_3.ChangeTrue();
                    script_4.ChangeFalse();
                }
                else if (clickedGameObject.name == "Player_4")
                {
                    script_1.ChangeFalse();
                    script_2.ChangeFalse();
                    script_3.ChangeFalse();
                    script_4.ChangeTrue();
                }
            }
        }
        else if (isPlaying == false)
        {
            script_1.ChangeFalse();
            script_2.ChangeFalse();
            script_3.ChangeFalse();
            script_4.ChangeFalse();
        }
    }

    public void isPlayingFalse()
    {
        isPlaying = false;
    }

}

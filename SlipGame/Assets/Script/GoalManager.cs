using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    //生成するゴールのオブジェクト
    public GameObject Goal1;
    public GameObject Goal2;
    public GameObject Goal3;
    public GameObject Goal4;
    //ゴールが連続で同じ場所になるのを防ぐ用の変数
    int before_rnd_place;
    //ゴール地点の発生場所
    Vector2[] place = {new Vector2(-4f,3.6f),new Vector2(-1f,3f),new Vector2(3.2f,3.65f), new Vector2(0.82f,2.41f), new Vector2(3.76f,1.81f),
        new Vector2(-3.4f,1.84f), new Vector2(-0.38f,1.21f), new Vector2(2.61f,0.61f),new Vector2(-1.62f,-0.58f),new Vector2(-4f,-1.15f),
        new Vector2(3.22f,-1.17f),new Vector2(-2.2f,-1.76f),new Vector2(0.8f,-2.3f),new Vector2(-1.62f,-3.58f),new Vector2(-2.8f,-4.2f),
        new Vector2(1.41f,-4.2f),new Vector2(3.8f,-3.58f) };
    // Start is called before the first frame update
    void Start()
    {
        before_rnd_place = 100;
        SetPlace();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //スペースを押したら
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetPlace();
        }
        */
    }
    //ゴール地点の生成
    public void SetPlace() {
        int rnd_place = Random.Range(0, 16 + 1);
        int rnd_player = Random.Range(0, 3 + 1);
        //同じ場所に出現するのを防ぐ
        while (rnd_place == before_rnd_place) {
            rnd_place = Random.Range(0, 16 + 1);
        }
        before_rnd_place = rnd_place;

        if (rnd_player == 0)
        {
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            Instantiate(Goal1, place[rnd_place], Quaternion.identity);
        }
        else if (rnd_player == 1) {
            Instantiate(Goal2, place[rnd_place], Quaternion.identity);
        }
        else if (rnd_player == 2)
        {
            Instantiate(Goal3, place[rnd_place], Quaternion.identity);
        }
        else if (rnd_player == 3)
        {
            Instantiate(Goal4, place[rnd_place], Quaternion.identity);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager2 : MonoBehaviour
{
    //生成するゴールのオブジェクト
    public GameObject Goal1;
    public GameObject Goal2;
    public GameObject Goal3;
    public GameObject Goal4;
    //ゴールが連続で同じ場所になるのを防ぐ用の変数
    int before_rnd_place;
    //ゴール地点の発生場所
    Vector2[] place = {new Vector2(-595f,732f),new Vector2(482f,732f),new Vector2(-243f,492f), new Vector2(120f,492f), new Vector2(-840f,377f),
        new Vector2(721f,377f), new Vector2(233f,248f), new Vector2(-483f,128f),new Vector2(-603f,-346f),new Vector2(117f,-346f),
        new Vector2(-361f,-469f),new Vector2(475f,-471f),new Vector2(-722f,-583f),new Vector2(-484f,-710f),new Vector2(2f,-715f),
        new Vector2(227f,-828f),new Vector2(730f,-223f) };
    // Start is called before the first frame update
    void Start()
    {
        before_rnd_place = 100;
        SetPlace();
    }

    // Update is called once per frame
    void Update()
    {
        
        /*上キーを押したらを
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetPlace();
        }
        */
        
    }
    //ゴール地点の生成
    public void SetPlace()
    {
        int rnd_place = Random.Range(0, 16 + 1);
        int rnd_player = Random.Range(0, 3 + 1);
        //同じ場所に出現するのを防ぐ
        while (rnd_place == before_rnd_place)
        {
            rnd_place = Random.Range(0, 16 + 1);
        }
        before_rnd_place = rnd_place;

        if (rnd_player == 0)
        {
            //Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
            Instantiate(Goal1, place[rnd_place], Quaternion.identity);
        }
        else if (rnd_player == 1)
        {
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

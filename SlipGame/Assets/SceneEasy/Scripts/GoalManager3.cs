using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager3 : MonoBehaviour
{
    //生成するゴールのオブジェクト
    public GameObject Goal1;
    public GameObject Goal2;
    public GameObject Goal3;
    public GameObject Goal4;
    //ゴールが連続で同じ場所になるのを防ぐ用の変数
    int before_rnd_place;
    //ゴール地点の発生場所
    Vector2[] place = {new Vector2(-300f,215f),new Vector2(-105f,-185f),new Vector2(297f,24f), new Vector2(297f,-382f)};
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
        int rnd_place = Random.Range(0, 3 + 1);
        int rnd_player = Random.Range(0, 3 + 1);
        //同じ場所に出現するのを防ぐ
        while (rnd_place == before_rnd_place)
        {
            rnd_place = Random.Range(0, 3 + 1);
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

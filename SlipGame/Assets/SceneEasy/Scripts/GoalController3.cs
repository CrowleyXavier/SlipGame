using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController3 : MonoBehaviour
{
    public string Player;
    GameObject ObjectManager;
    GameObject TextManager;


    GoalManager3 goal_script;
    ScoreManager3 score_script;
    CountManager3 count_script;

    // Start is called before the first frame update
    void Start()
    {
        ObjectManager = GameObject.Find("ObjectManager");
        TextManager = GameObject.Find("TextManager");
        goal_script = ObjectManager.GetComponent<GoalManager3>();
        score_script = TextManager.GetComponent<ScoreManager3>();
        count_script = TextManager.GetComponent<CountManager3>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == Player)
        {   //タグのついたオブジェクトと衝突時
            Debug.Log(Player);
            //    Destroy(this.gameObject);
            Destroy(gameObject, .5f);
            goal_script.SetPlace();
            score_script.UpScore();
            count_script.CountReset();
        }

    }


}

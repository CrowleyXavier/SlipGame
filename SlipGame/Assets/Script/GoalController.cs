using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    
    public string Player;
    GameObject GoalManager;
    GoalManager script;
    // Start is called before the first frame update
    void Start()
    {
        GoalManager = GameObject.Find("GoalManager");

        script = GoalManager.GetComponent<GoalManager>();
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
            script.SetPlace();
        }

    }
    

}

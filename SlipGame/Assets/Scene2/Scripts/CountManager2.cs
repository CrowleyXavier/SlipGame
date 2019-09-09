using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountManager2 : MonoBehaviour
{
    public GameObject count_object = null; // Textオブジェクト
    public int count_num = 0; // カウント変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text count_text = count_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        count_text.text = "Count:" + count_num;
        // 色を指定
        count_text.color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
    }
    //PlayerController2で使用
    public void CountAdd() {
        count_num++;
    }
    //GoalControllerで使用
    public void CountReset() {
        count_num = 0;
    }
}

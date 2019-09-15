using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager2 : MonoBehaviour
{

    GameObject ObjectManager; //キャラクターのオブジェクトそのものが入る変数

    PlayerManager2 player_manager_script;

    public Text timerText;
    public GameObject gameOverText;
    public GameObject TitleButton;
    public float TotalTime;
    int time;

    // Start is called before the first frame update
    void Start()
    {
        ObjectManager = GameObject.Find("ObjectManager");
        player_manager_script = ObjectManager.GetComponent<PlayerManager2>();
        gameOverText.SetActive(false);
        TitleButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime -= Time.deltaTime;
        time = (int)TotalTime;
        timerText.color = new Color(255f, 255f, 255f, 1.0f);

        if (time < 0)
        {
            StartCoroutine("GameOver");
        }
        if (time < 0)
        {
            time = 0;
            player_manager_script.isPlayingFalse();
        }
        timerText.text = "Time:" + time.ToString();
    }

    IEnumerator GameOver()
    {
        gameOverText.SetActive(true);
        TitleButton.SetActive(true);
        yield return new WaitForSeconds(2.0f);
    /*    if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("title");
        }
    */
    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    // ボタンをクリックするとBattleSceneに移動します
    public void LoadSceneHard()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void LoadSceneEasy()
    {
        SceneManager.LoadScene("SceneEasy");
    }

    public void LoadSceneTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

}

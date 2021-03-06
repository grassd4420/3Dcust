using System.Collections;
using System.Collections.Generic;
using script;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageClearAnimation : MonoBehaviour
{
    private float countup2 = 0.0f;
    public Image sen1;
    public Image sen2;
    public Image sen3;

    //時間を表示するText型の変数
    public Text timeText;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        countup2 += Time.deltaTime;
        //timeText.text = countup2.ToString("f1") + "秒";

        //描画開始
        if (countup2 >= 1.0f)
        {
            sen1.fillAmount += Time.deltaTime * 2f;
        }
        //sen1.fillAmount += Time.deltaTime * 2f;

        //以下時間が来たら描画
        if (countup2 >= 2.0f)
        {
            sen2.fillAmount += Time.deltaTime * 2f;
        }
        if (countup2 >= 2.5f)
        {
            sen3.fillAmount += Time.deltaTime * 2f;
        }
        if (Input.GetKeyDown("space")&& countup2 >= 2.0f)
        {
            SceneManager.LoadScene("StageSelect");
        }
        if (Input.GetKeyDown(KeyCode.Space) && countup2 >= 2.0f)
        {
            SceneManager.LoadScene(SceneNames.StageSelect);
        }
    }
}

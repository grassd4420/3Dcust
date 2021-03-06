using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2IntroAnimation : MonoBehaviour
{
    private float countup = 0.0f;
    public Image sen1;
    public Image sen2;
    public Image sen3;
    public Image gro1;
    public Image gro2;
    public Image mou1;
    public Image sky1;
    public Image sky2;
    public Image sky3;
    public Image sky4;
    public Image sky5;
    public Image stage;
    public Image mess;

    //時間を表示するText型の変数
    public Text timeText;

    public Image Draw;//関数に渡す際に描画する画像を格納する用
    private float DrawSpeed;//描画スピード

    //イメージを描画する関数(描画する画像 ,　描画スピード)
    private void DrawaImages(Image Draw, float DrawSpeed)
    {
        Draw.fillAmount += Time.deltaTime * DrawSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        countup += Time.deltaTime;
        timeText.text = countup.ToString("f1") + "秒";

        //描画開始
        DrawaImages(sen1, 0.13f);

        //以下時間が来たら描画
        if (countup >= 2.0f)
        {
            DrawaImages(sen2, 0.15f);
        }

        if (countup >= 2.4f)
        {
            DrawaImages(sen3, 0.15f);
        }

        if (countup >= 9.8f)
        {
            DrawaImages(gro1, 0.3f);
        }

        if (countup >= 10.5f)
        {
            DrawaImages(mou1, 0.3f);
        }

        if (countup >= 10.5f)
        {
            DrawaImages(gro2, 0.3f);
        }

        if (countup >= 13.2f)
        {
            DrawaImages(sky1, 0.9f);
        }

        if (countup >= 15f)
        {
            DrawaImages(sky2, 1f);
        }

        if (countup >= 16f)
        {
            DrawaImages(sky3, 1.5f);
        }

        if (countup >= 17f)
        {
            DrawaImages(sky4, 1.5f);
        }

        if (countup >= 17.5f)
        {
            DrawaImages(sky5, 1.5f);
        }

        if (countup >= 18.5f)
        {
            DrawaImages(stage, 1.5f);
        }

        if (countup >= 19.5f)
        {
            DrawaImages(mess, 1.5f);
        }

    }

}

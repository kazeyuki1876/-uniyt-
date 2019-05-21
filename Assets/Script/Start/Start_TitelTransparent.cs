using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_TitelTransparent : MonoBehaviour
{


    //GameObject.Find("GameObject.name").GetComponent<sparent.name>().Void.name();
    public bool test = true;
    public static bool TitelTransparentSwitch = false; //
    //Color RGBA
    float changeRed = 1.0f;
    float changeGreen = 1.0f;
    float cahngeBlue = 1.0f;
    float cahngeAlpha = 1.0f;
    public float CahngeAlpha_Speed ;
    //------------------------------
   



    void Update()
    {
        TitelTransparent();
        Release();
    }
    void TitelTransparentON() {
        TitelTransparentSwitch = true;
        ReleaseOFF = false;
    }
    bool I =false;
    void TitelTransparent()
    {
        if (TitelTransparentSwitch&& !I)
        {
            if (this.transform.localScale.x < 5)
            {
                this.transform.localScale = new Vector3(transform.localScale.x + Measure, transform.localScale.y + Measure, 1);
            }
            else
            {
                this.transform.localScale = new Vector3(5.0f, 5.0f, 1);
                I = true;
            }
            if (this.transform.localScale.x > 5)
            {
                this.transform.localScale = new Vector3(transform.localScale.x + Measure, transform.localScale.y + Measure, 1);
            }
            else
            {
                this.transform.localScale = new Vector3(5.0f, 5.0f, 1);
                 I = true;
            }
        }
       


        
        if (TitelTransparentSwitch && cahngeAlpha > 0.0f)
        {
            cahngeAlpha = cahngeAlpha - Time.deltaTime * CahngeAlpha_Speed;
            this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
        }
        else if (TitelTransparentSwitch&&cahngeAlpha <= 0.0f) {
            TitelTransparentSwitch = false;

            Debug.Log("cahngeAlpha"+ cahngeAlpha+ "％　、Titel　透明化完了");
            GameObject.Find("StartController").SendMessage("CameraEnlarge");//能调用public和private类型函数
        }


    }
    bool ReleaseOFF = true;
    bool ReleaseOstatus = true;
    public float Measure = 0.01f;
    public float MINScale =5;
    public float MAXScale=6;

    void Release()
    {
        if (ReleaseOFF) { 
            if (ReleaseOstatus && this.transform.localScale.x < MAXScale)
            {
                this.transform.localScale = new Vector3(transform.localScale.x + Measure, transform.localScale.y + Measure, 1);
            } else if(ReleaseOstatus && this.transform.localScale.x > MAXScale)
            {
                ReleaseOstatus = false;
            }
            if (!ReleaseOstatus && this.transform.localScale.x > MINScale)
            {
                this.transform.localScale = new Vector3(transform.localScale.x - Measure, transform.localScale.y - Measure, 1);
            }
            else if (!ReleaseOstatus && this.transform.localScale.x < MINScale)
            {
                ReleaseOstatus = true;
            }
        }
    }
}

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
      
    }
    void TitelTransparentON() {
        TitelTransparentSwitch = true;
       
    }
    bool I =false;
    void TitelTransparent()
    {
      
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

    
}

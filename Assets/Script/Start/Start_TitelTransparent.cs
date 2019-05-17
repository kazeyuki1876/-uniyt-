using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_TitelTransparent : MonoBehaviour
{


    //GameObject.Find("脚本所在的物体的名字").GetComponent<脚本名>().函数名();
    public  bool test = true;
    public static bool TitelTransparentOff = false; //
    //Color RGBA
    float changeRed = 1.0f;
    float changeGreen = 1.0f;
    float cahngeBlue = 1.0f;
    float cahngeAlpha = 1.0f;
  
    void TitelTransparent()
    {
      
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            TitelTransparentOff = true;
        }
        if (TitelTransparentOff) {
            cahngeAlpha = cahngeAlpha - Time.deltaTime * 0.3f;
        }
        if (test == false) { Debug.Log("test" + test); }


        // 元の画像の色のまま、半透明になって表示される。
        this.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
    }
   /* public void test() {
        Debug.Log("test");
    }*/
  
    
           
   
   
    

}

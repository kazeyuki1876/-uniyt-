using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Start_StartButton : MonoBehaviour
{
    bool OnClickOFF =true;
    public void OnClick()
    {
        if (OnClickOFF) {
            GameObject.Find("StartController").SendMessage("CameraMetastasis");// カメラ縮小
            Debug.Log("おされた");
            OnClickOFF = false;
        }
       

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Camera : MonoBehaviour
{
    /*
    カメラMAXサイズ13.7今までの方がいい
    カメラMINサイズ10.9
    巻き0.61
    いたスト　2.02*/
    public bool CameraMetastasisSwitch = false;//カメラ転移
    public bool CameraEnlargeswitch = false;//カメラ拡大
    bool i = true;
    public float Speed;//移転速度
    public float Acceleration;//加速度
    public float MAXAcceleration;//MAX移転速度
    public float TransformPositionX;//目的のX
    public void Start()
    {
        Camera.main.orthographicSize = 13.7f;//最初のカメラサイズ
    }
    void Update()
    {
        CameraMetastasis();
        CameraEnlarge();
    }

    void CameraMetastasisON() {
        CameraMetastasisSwitch = true;
        Debug.Log("CameraMetastasisON" + CameraMetastasisSwitch);
    }

    void CameraMetastasis() {
        if (CameraMetastasisSwitch) {
            if (Camera.main.orthographicSize >= 10.01f) //このサイズより //
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize - 0.05f;
            }
            else
            {
                Camera.main.orthographicSize = 10.0f;
                CameraMetastasisSwitch = false;
                GameObject.Find("StartController").SendMessage("TitelTransparent");//StartControllerに戻る
                Debug.Log("CameraMetastasis" + CameraMetastasisSwitch+ "orthographicSize" + Camera.main.orthographicSize);
            }
        }
    }
    void CameraEnlargeON() {
        CameraEnlargeswitch = true;
        Debug.Log("CameraEnlargeswitch" + CameraEnlargeswitch);
    }
    void CameraEnlarge(){
        if (CameraEnlargeswitch && this.transform.position.x> TransformPositionX)
        {
            if (Speed > MAXAcceleration){ Speed = MAXAcceleration;}// MAX移転速度
            this.transform.position = new Vector3(transform.position.x - Speed, transform.position.y, -10.0f);
            Speed = Speed + Time.deltaTime * Acceleration;//加速度
        }
        else if(CameraEnlargeswitch &&this.transform.position.x < TransformPositionX)
        {
            this.transform.position = new Vector3(TransformPositionX, transform.position.y, -10.0f);
            CameraEnlargeswitch = false;
            Debug.Log("転移完成　CameraEnlarge" + CameraEnlargeswitch + "transform.position.y" + this.transform.position.y);//StartControllerに戻る
            GameObject.Find("StartController").SendMessage("Stagebudge");
        }
    }
}


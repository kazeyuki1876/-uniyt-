using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Camera : MonoBehaviour
{
    //カメラMAXサイズ13.7今までの方がいい
    //カメラMINサイズ10.9
    //巻き0.61
    //いたスト　2.02
    public bool CameraMetastasisSwitch = false;//カメラ転移
    public bool CameraEnlargeswitch = false;//カメラ拡大
    bool i = true;
    public float Acceleration;//移転速度
    public float MAXAcceleration;//MAX移転速度
    public float TransformPositionX;
    public void Start()
    {
        Camera.main.orthographicSize = 13.7f;
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
            if (Camera.main.orthographicSize >= 10.01f) //小于一个放大范围后就不继续放大了 //
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize - 0.05f;
            }
            else
            {
                Camera.main.orthographicSize = 10.0f;
                CameraMetastasisSwitch = false;
                GameObject.Find("StartController").SendMessage("TitelTransparent");//能调用public和private类型函数
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
            if (Acceleration > MAXAcceleration)
            {
                Acceleration = MAXAcceleration;
            }
            this.transform.position = new Vector3(transform.position.x - Acceleration, transform.position.y, -10.0f);

            Acceleration = Acceleration + Time.deltaTime * 0.02f;
        }
        else if(CameraEnlargeswitch &&this.transform.position.x < TransformPositionX)
        {
            this.transform.position = new Vector3(TransformPositionX, transform.position.y, -10.0f);
            CameraEnlargeswitch = false;
            Debug.Log("転移完成　CameraEnlarge" + CameraEnlargeswitch + "transform.position.y" + this.transform.position.y);
            GameObject.Find("StartController").SendMessage("Shi");
        }

    }
    /*
    void CameraMetastasis() {
        Debug.Log("OK");
       // OFFtest = false;
        if (Input.GetKeyDown(KeyCode.J))
        {
            CameraEnlargeswitch = true;
        }
        Enlarge();

        
        if (i)
        {
            Debug.Log("OFF");
            i = false;
        }


        
    }
   
    */
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Camera : MonoBehaviour
{

    public  bool OFFtest;

    

    public bool CameraMetastasis = false;//カメラ転移
    public bool CameraEnlarge = false;//カメラ拡大
    


    bool i = true;

    public float Acceleration = 0.1f;
    public void Start()
    {
        Camera.main.orthographicSize = 13.7f;

       //OFFtest = GameObject.Find("Titel").GetComponent<Start_TitelTransparent>().test;
       
    }


    void Update()
    {
        OFFtest = false;
        if (Input.GetKeyDown(KeyCode.J)) {
            CameraEnlarge = true;
        }
        Enlarge();

        if (Acceleration > 0.5f)
        {
            Acceleration = 0.5f;
        }
       
            this.transform.position = new Vector3(transform.position.x - Acceleration, transform.position.y, -10.0f);

            Acceleration = Acceleration + Time.deltaTime * 0.02f;
            if (i)
            {
                Debug.Log("OFF");
                i = false;
            }
        
    }
    void Enlarge() {
        if (CameraEnlarge) {
            if (Camera.main.orthographicSize >= 10.01f) //小于一个放大范围后就不继续放大了 
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize - 0.05f;
            }
            else
            {
                Camera.main.orthographicSize = 10.0f;
                CameraEnlarge = false;
            }
        }
       
    }

    void daiyong() {
        /*if (Input.GetKeyDown(KeyCode.J))
        {
            OFF = true;
        }

        if (OFF2 == true)
        {
            if (Camera.main.orthographicSize >= 5.1f) //小于一个放大范围后就不继续放大了 
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize - 0.05f;
            }
        }

       
        */
    }
}


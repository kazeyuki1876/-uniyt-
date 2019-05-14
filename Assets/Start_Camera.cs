using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Camera : MonoBehaviour
{
    public bool OFF = false;//カメラ転移

    public bool OFF2 = false;//カメラ拡大
    bool i = true;
   
    public float Acceleration = 0.1f;

    void Update()
    {
        if (OFF2 == true)
        {
            if (Camera.main.orthographicSize >=5.1f) //小于一个放大范围后就不继续放大了 
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize -0.05f;
            }
        }











        if (Input.GetKeyDown(KeyCode.J))
        {
           OFF = true;
        }

        if (Acceleration > 0.5f) {
            Acceleration = 0.5f;
        }
        if (OFF)
        {
            this.transform.position = new Vector3(transform.position.x - Acceleration, transform.position.y , -10.0f);

            Acceleration = Acceleration + Time.deltaTime * 0.02f;
            if (i)
            {
                Debug.Log("OFF");
                i = false;
            }
        }
    }
}


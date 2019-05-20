using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_StartController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Camera;
    public GameObject TitleText;
    //GameObject.Find("脚本所在的物体的名字").SendMessage("函数名");//能调用public和private类型函数
    void Start()
    {
        GameObject.Find("Main Camera").SendMessage("daiyong");//能调用public和private类型函数
        /*
         Debug.Log(Camera.name);
        Debug.Log(TitleText);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

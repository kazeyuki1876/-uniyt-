using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_StartController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Camera;
    public GameObject TitleText;
    //GameObject.Find("脚本所在的物体的名字").SendMessage("函数名");//能调用public和private类型函数
    void Start()
    {
        CameraMetastasis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CameraMetastasis (){
        GameObject.Find("Main Camera").SendMessage("CameraMetastasisON");// 
    }
    
    void TitelTransparent() {
        GameObject.Find("Title").SendMessage("TitelTransparentON");//
        Debug.Log("TitelTransparent");
    }
    void CameraEnlarge()
    {
        GameObject.Find("Main Camera").SendMessage("CameraEnlargeON");// 
    }
    void Shi() {
        Debug.Log("シーンの転移だ");
    }
}

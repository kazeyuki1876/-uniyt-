using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Start_StartController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Camera;
    public GameObject Ochihana1;
    //GameObject.Find("脚本所在的物体的名字").SendMessage("函数名");//能调用public和private类型函数
    void Start()
    {
      
        //CameraMetastasis();//初め
        //Invoke("Ochi",1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CameraMetastasis() {
        GameObject.Find("Main Camera").SendMessage("CameraMetastasisON");// カメラ縮小
    }

    void TitelTransparent() {
        GameObject.Find("Title").SendMessage("TitelTransparentON");//タイトル透明化
        Debug.Log("TitelTransparent");
    }
    void CameraEnlarge()
    {
        GameObject.Find("Main Camera").SendMessage("CameraEnlargeON");// カメラ移動、
    }
    //
    void Stagebudge() {
        Debug.Log("シーンの転移だ");
        SceneManager.LoadScene("M");//シーンの切り替え
        

    }
    void Ochi() {
        Ochihana1 = Instantiate(Ochihana1, new Vector3(-15.0f, 50.0f, 15.0f), Quaternion.identity);　//花びらが上のから落ちるエフェクト
    }
}

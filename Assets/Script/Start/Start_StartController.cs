using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Start_StartController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Camera;
    public GameObject Ochihana1;
    //GameObject.Find("GameObject.name").SendMessage("Void.ma,e");//public private
    void CameraMetastasis() {
         Invoke("Ochi", 0.30f);
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
    void StagebudgeOn() {
        Invoke("Stagebudge", 10.0f);
        Debug.Log("シーンの転移だ");
     
    }
    void Stagebudge (){
        //SceneManager.LoadScene("M");//シーンの切り替え
    }
    void Ochi() {
        Ochihana1 = Instantiate(Ochihana1, new Vector3(-20.0f,30.0f, 15.0f), Quaternion.identity);　//花びらが上のから落ちるエフェクト
    }
}

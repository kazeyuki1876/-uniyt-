using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Start_StartController : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Camera;
    public GameObject Ochihana1;
    public int i;
    //GameObject.Find("GameObject.name").SendMessage("Void.ma,e");//public private
    void GameStart() {

        if (i < 1)
        {
            Debug.Log("GameStart   UmehanaScaleEnlarge  タイトル画像全体拡大 梅枝移動");//タイトル画像全体拡大
            UmeEdeMetastasis();
            UmehanaScaleEnlarge();

            i++;
        }
        else if (i < 2)
        {
            Debug.Log("GameStart   TitelTransparentON  タイトル透明化");//タイトル透明化
            i++;
            TitelTransparent();
        }
        else if (i < 3)
        {
            Debug.Log("GameStart  CameraMetastasis  カメラ移動");// カメラ移動、
            CameraEnlarge();
            i++;
        }
        else if (i < 4) {
            Debug.Log("GameStart  シーンの転移");// カメラ移動、
            Stagebudge();
            i++;

        }
      

    }

    void　UmehanaScaleEnlarge() {
        GameObject.Find("TitleImeji").SendMessage("UmehanaScaleEnlargeswitchNO");//タイトル画像全体拡大
        
    }
   void UmeEdeMetastasis()
    {
        GameObject.Find("umeL").SendMessage("EdaaMetastasisSwitchON");// 梅枝移動
        GameObject.Find("umeR").SendMessage("EdaaMetastasisSwitchON");// 
    }

    void TitelTransparent() {
        GameObject.Find("Title").SendMessage("TitelTransparentON");//タイトル透明化
     
    }


    
    void CameraEnlarge()
    {
       
        
        GameObject.Find("Main Camera").SendMessage("CameraEnlargeON");// カメラ移動、
    }
    //
    void StagebudgeOn() {
      
     
    }
    void Stagebudge (){
       // SceneManager.LoadScene("M");//シーンの切り替え
    }
    void Ochi() {
        Ochihana1 = Instantiate(Ochihana1, new Vector3(-20.0f,30.0f, 15.0f), Quaternion.identity);　//花びらが上のから落ちるエフェクト
    }
}

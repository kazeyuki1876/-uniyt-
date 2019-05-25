using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン転移　には必要

public class Start_UmeNoHanabira : MonoBehaviour
{
    public bool ImejiMetastasisSwitch = false;
    public float StartIchi;
    public float EndiCHI;
    public float Speed =2.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //StagebudgeOn();
       
        ImejiMetastasis();       // if () { }
        // this.transform.position = new Vector3(transform.position.x - Speed, transform.position.y, -10.0f);
    }
    void ImejiMetastasis() {
        if (ImejiMetastasisSwitch)
        {
            if (this.transform.position.x < EndiCHI)//EndiCHI =0;
            {
                this.transform.position = new Vector3(transform.position.x + Speed, transform.position.y - Speed, -0.0f);
                if (this.transform.position.x > -25.0f)
                {

                    SceneManager.LoadScene("M");//シーンの切り替え
                    Debug.Log("そろそろしーん転移すうね");
                    // GameObject.Find("StartController").SendMessage("GameStart");// GameStartに戻り 遅いな
                }
            }
        }
    }
    void ImejiMetastasisSwitchON()
    {
        Debug.Log("梅の花びらをカメラに");
        ImejiMetastasisSwitch = true;
    }
    void StagebudgeOn() {
        
    }
}
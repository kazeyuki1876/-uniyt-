using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Controller : MonoBehaviour
{
    public bool CamaraSwitch =false;
    public bool CamaraSwitchON = true;
    public float CamaraSwitchTimeINT;
    public float CamaraSwitchTime;
    // Start is called before the first frame update
    void Start()
    {
        CamaraSwitchTime = CamaraSwitchTimeINT;
    }

    // Update is called once per frame
    void Update()

    {
        if (CamaraSwitchON && Input.GetKeyDown(KeyCode.J)) {
            CamaraSwitchON = false;
            if (!CamaraSwitch)
            {
                GameObject.Find("Main Camera").SendMessage("EnlargeON");// 梅枝移動
                CamaraSwitchController();
            }
            else if (CamaraSwitch) {
                GameObject.Find("Main Camera").SendMessage("EnlargeOFF");
                CamaraSwitchController();
            }
        }
        CamaraSwitchControllerON();

    }

    void CamaraSwitchController()
    {
        if (CamaraSwitch)
        {
            CamaraSwitch = false;
        }
        else if (!CamaraSwitch)
        {
            CamaraSwitch = true;
        }

        


    }
    void CamaraSwitchControllerON()
    {

        if (!CamaraSwitchON && CamaraSwitchTime > 0.0f)
        {
            CamaraSwitchTime = CamaraSwitchTime - Time.deltaTime;
        }
        else {
            CamaraSwitchON = true;
            CamaraSwitchTime = CamaraSwitchTimeINT;
        }

    }
    /*
     GameObject.Find("Main Controller").SendMessage("MoveON");// camara移動
           
          // 梅枝移動
     */
}

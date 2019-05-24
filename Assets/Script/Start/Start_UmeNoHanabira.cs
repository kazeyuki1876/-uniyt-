using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if (ImejiMetastasisSwitch)
        {
            if (this.transform.position.x< EndiCHI)//EndiCHI =0;
            {
                this.transform.position = new Vector3(transform.position.x + Speed, transform.position.y - Speed, -0.0f);
            }
        }
       // if () { }
        // this.transform.position = new Vector3(transform.position.x - Speed, transform.position.y, -10.0f);
    }
    void ImejiMetastasisSwitchON()
    {
        Debug.Log("test2");
        ImejiMetastasisSwitch = true;
    }
}
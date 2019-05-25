using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_TitelImeji : MonoBehaviour
{
   
    public bool UmehanaScaleEnlargeswitch = false;
    public float Acceleration;//加速度
    public float MAXAcceleration;//MAX

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UmehanaScaleEnlarge();

    }
    void UmehanaScaleEnlargeswitchNO() {
        UmehanaScaleEnlargeswitch = true;
    }
    void UmehanaScaleEnlarge(){
        if (UmehanaScaleEnlargeswitch) { 
         if (this.transform.localScale.x < MAXAcceleration) {
           
            this.transform.localScale = new Vector3(transform.localScale.x + Acceleration, transform.localScale.y + Acceleration, 1.0f);
            }
        }
    }
}

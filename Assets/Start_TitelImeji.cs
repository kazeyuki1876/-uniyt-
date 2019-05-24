using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_TitelImeji : MonoBehaviour
{
    public float UmehanaScaleX;
    public float UmehanaScaleY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UmehanaScaleX < 0.15f) { 
        UmehanaScaleX = UmehanaScaleX + Time.deltaTime*0.2f;
        UmehanaScaleY = UmehanaScaleY + Time.deltaTime*0.2f;
        this.transform.localScale = new Vector3(transform.localScale.x + UmehanaScaleX, transform.localScale.y  +UmehanaScaleY, 1.0f );
        }

    }
}

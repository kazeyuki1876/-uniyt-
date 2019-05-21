using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OchiHANA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 20.0f);
    }

    // Update is called once per frame
    void Destroy(){
        Destroy(this.gameObject);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Eda1 : MonoBehaviour
{
    public bool OFF = false;
    bool i = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OFF = true;
        }
        if (OFF)
        {
            this.transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y - 0.1f, 15.0f);
            if (i)
            {
                Debug.Log("Eta1ON");
                i = false;
            }
        }
    }
}
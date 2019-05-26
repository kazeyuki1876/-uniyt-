using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1_Camera : MonoBehaviour
{
    public bool CameraMoveSwitchON = false;
    public bool CameraEnlargeswitchON = false;
    public bool CameraMetastasisSwitchOFF = false;
    public float MINEnlargesScaie = 11.40f;
    public float MAXEnlargesScaie = 13.70f;


    public float Speed;
    public float TransformPositionX1;
    public float TransformPositionX2;
    public float TransformPositionX3;
    public float StartTransformPositionX = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(StartTransformPositionX, transform.position.y, -50.0f);
    }

    // Update is called once per frame
    void Update()
    {
        CameraMoveSwitch();
        CameraEnlargeON();
        CameraEnlargeOFF();
    }
    void MoveON(){ CameraMoveSwitchON = true; }
    void EnlargeON(){
        CameraEnlargeswitchON = true;
    }
    void EnlargeOFF(){ CameraMetastasisSwitchOFF = true; }
void CameraMoveSwitch()
    {
        if (CameraMoveSwitchON && this.transform.position.x > TransformPositionX1)
        {

            this.transform.position = new Vector3(transform.position.x - Speed, transform.position.y, -50.0f);

        }
        else if (CameraMoveSwitchON && this.transform.position.x  <= TransformPositionX1) {
            CameraMoveSwitchON = false;
              this.transform.position = new Vector3(TransformPositionX1, transform.position.y, -50.0f);
            TransformPositionX1 = TransformPositionX1 - 70.0f;

        }
    }

    void CameraEnlargeON()
    {
        if (CameraEnlargeswitchON)
        {
            if (Camera.main.orthographicSize >= MINEnlargesScaie-0.1f) //このサイズより //
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize - 0.05f;
            }
            else
            {
                Camera.main.orthographicSize = MINEnlargesScaie;
                CameraEnlargeswitchON = false;
            }
        }
    }

    void CameraEnlargeOFF()
    {
        if (CameraMetastasisSwitchOFF)
        {
            if (Camera.main.orthographicSize <= MAXEnlargesScaie-0.1f) //このサイズより //
            {
                Camera.main.orthographicSize = Camera.main.orthographicSize + 0.05f;
            }
            else
            {
                Camera.main.orthographicSize = MAXEnlargesScaie;
                CameraMetastasisSwitchOFF = false;
                MoveON();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//한글

public class RoulelleCtrl : MonoBehaviour
{
    private float rotationSpeed = 0;

    void Update()
    {
        this.transform.Rotate(0, 0, 0);
        //1.화면 누르면 어떻게 감지하지?
        bool isDownL = Input.GetMouseButtonDown(0);

        if (isDownL)
        {
            Debug.Log("L버튼 눌렀습니다");
            rotationSpeed = 10;
        }

        bool isDownR = Input.GetMouseButtonDown(1);

        if (isDownR)
        {
            Debug.Log("R버튼 눌렀습니다");
            rotationSpeed = -10;
        }
        //if (isDown)
        //{
        //    Debug.Log("눌렀습니다");
        //}
        //회전을 어떻게 시키지?
        this.transform.Rotate(0, 0, rotationSpeed);

        //속도 줄이고
        rotationSpeed = rotationSpeed * 0.96f;
        Debug.Log(rotationSpeed);
    }
}

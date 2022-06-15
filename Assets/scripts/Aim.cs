using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public RectTransform aim;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; // 실제 마우스 커서 숨기기
    }

    // Update is called once per frame
    void Update()
    {
        aim.position = Input.mousePosition;
    }
}

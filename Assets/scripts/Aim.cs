using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    // Canvas에 있는 aim 이미지
    // RectTransform -> 기존 Transform과 달리 비율로 계산됨 (앵커)
    public RectTransform aim;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; // 실제 마우스 커서 숨기기
    }

    // Update is called once per frame
    void Update()
    {
        aim.position = Input.mousePosition; // 마우스를 항상 따라 다니도록 설정
    }
}

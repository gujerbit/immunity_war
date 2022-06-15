using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rigidBody;

    private void Awake() // 스크립트가 실행될 때 한 번만 호출됨, 두번째로 호출됨
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    private void FixedUpdate() // 일정 주기마다 계속 호출됨 (Default 0.02s)
    {
        float moveX = Input.GetAxis("Horizontal"); // x축 힘 (-1f ~ 1f)
        float moveY = Input.GetAxis("Vertical"); // y축 힘 (-1f ~ 1f)

        rigidBody.velocity = new Vector2(moveX, moveY) * moveSpeed;
    }

    void Update() // 매 프레임마다 호출됨 (주기가 일정치 않음)
    {

    }
}

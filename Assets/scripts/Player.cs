using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 플레이어 이동 속도
    public Bullet bullet; // 총알

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

        rigidBody.velocity = new Vector2(moveX, moveY) * moveSpeed; // 플레이어 이동
    }

    void Update() // 매 프레임마다 호출됨 (주기가 일정치 않음)
    {
        if (Input.GetMouseButtonDown(0)) // 0 왼쪽 버튼, 1 오른쪽 버튼, 2 휠 버튼
        {
            CreateBullet(); // 마우스 왼쪽 버튼 누르면 총알 발사
        }
    }

    private void CreateBullet() // 총알 생성
    {
        // 타겟 좌표 - 나의 좌표 해주면 타겟까지의 벡터가 됨
        // Input.mousePosition은 screen 좌표이기 때문에 월드 좌표로 변환해주어야함
        Vector2 targetVector = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position;

        bullet = Instantiate(bullet, gameObject.transform.position, Quaternion.identity); // 나의 좌표(위치, 회전값)에서 총알 생성
        bullet.SetDirection(targetVector); // Bullet에 있는 SetDirection 함수 실행
    }
}

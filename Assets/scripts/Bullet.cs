using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 5f; // 총알의 속도

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDirection(Vector2 targetVector) // 총알이 날아갈 방향 설정
    {
        // 받아온 벡터를 normalized하여 위치 설정
        // normalized를 안하면 거리에 따른 힘이 추가되어 미친듯이 빨라짐
        rigidBody.velocity = targetVector.normalized * moveSpeed;

        StartCoroutine(SetDestroy()); // 총알 삭제 트리거 실행
    }

    private IEnumerator SetDestroy() // 자기 자신 삭제
    {
        yield return new WaitForSeconds(5); // 5초 뒤 아래 코드 실행

        Destroy(gameObject); // 자기 자신 삭제
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rigidBody;

    private void Reset() // first life cycle
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate() // 일정 주기마다 계속 실행됨 (Default: 0.02s)
    {
        
    }

    void Update() // 매 프레임마다 호출됨 (주기가 일정치 않음)
    {
        
    }
}

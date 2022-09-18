using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{ Rigidbody2D rb; //자료형 rigidbody2D라는 자료형을 가진 rb 변수 [자료형 변수 ;]
public float jumpPower; //퍼블릭 접근제한자 유니티 에디터 등 코드 밖에서 접근 가능.


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbody안에는중력포함다양한물리엔진구현되어있음.
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * 3; // (0.3) 위로 3만큼 힘을 받아 점프//간략하게 rigidbody를 가져와서 점프를 시킨다 정도의 개념만 알고있고 구글에 검색ㄱ
        }

void OnCollisionEnter2D(Collision2D collision2D)
        {
            if(Score.score > Score.bestScore)
            {
                Score.bestScore = Score.score;
            }

            SceneManager.LoadScene("GameOver");
        }

}
}

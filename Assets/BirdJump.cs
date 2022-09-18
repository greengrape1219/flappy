using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{ Rigidbody2D rb; //�ڷ��� rigidbody2D��� �ڷ����� ���� rb ���� [�ڷ��� ���� ;]
public float jumpPower; //�ۺ� ���������� ����Ƽ ������ �� �ڵ� �ۿ��� ���� ����.


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbody�ȿ����߷����Դپ��ѹ������������Ǿ�����.
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * 3; // (0.3) ���� 3��ŭ ���� �޾� ����//�����ϰ� rigidbody�� �����ͼ� ������ ��Ų�� ������ ���丸 �˰��ְ� ���ۿ� �˻���
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

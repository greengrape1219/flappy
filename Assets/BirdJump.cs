using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{ Rigidbody2D rb; //�ڷ��� rigidbody2D��� �ڷ����� ���� rb ���� [�ڷ��� ���� ;]
    public float jumpPower; //�ۺ� ���������� ����Ƽ ������ �� �ڵ� �ۿ��� ���� ����.
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbody�ȿ����߷����Դپ��ѹ������������Ǿ�����.
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        { 
            rb.velocity = Vector2.up * 3; // (0.3) ���� 3��ŭ ���� �޾� ����
            //�����ϰ� rigidbody�� �����ͼ� ������ ��Ų�� ������ ���丸 �˰��ְ� ���ۿ� �˻���
        }
    }
}

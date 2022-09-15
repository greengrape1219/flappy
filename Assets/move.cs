using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left*speed*Time.deltaTime ; //(-1,0,0)transform이 세개의 벡터를 가지기에
        //퍼블릭인 스피드 변수로 조절. 델타타임으로 프레임이 다른 사용자간 속도를 맞춤.
    }
}

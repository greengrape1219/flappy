using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
        float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>timeDiff)
        { GameObject newpipe= Instantiate(pipe); //pipe 생성하는 newpipe 변수
            newpipe.transform.position = new Vector3(0, Random.Range(-1.25f,3.25f), 0); //생성되는 파이프의 위치 변하도록
            timer = 0;
            Destroy(newpipe, 10.0f); // 몇 초뒤에 파이프가 사라지도록
        }
        
    }
}

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
        { GameObject newpipe= Instantiate(pipe); //pipe �����ϴ� newpipe ����
            newpipe.transform.position = new Vector3(0, Random.Range(-1.25f,3.25f), 0); //�����Ǵ� �������� ��ġ ���ϵ���
            timer = 0;
            Destroy(newpipe, 10.0f); // �� �ʵڿ� �������� ���������
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; //스코어 초기화
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString(); //tostring int->string으로 변환하는 것.
    }
}

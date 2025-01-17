using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class DiceCheck2 : MonoBehaviour
{
    private Rigidbody rb; // 각 주사위의 Rigidbody ==> 개별 정보를 저장해야되니까... dicescript에서 가져오는거보단 여기서 다시 한번 선언하는게 나을거같아요 (아님말고)
    //이 코드는 트리거존에다 안넣고 각각 주사위에 넣을거임.
    private Vector3 diceVelocity; // 각 주사위의 속도 저장할 벡터
    public int diceResult; // 이 주사위의 결과 (1~6) 

    public diceeye[] diceeyes = new diceeye[6];

    

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 주사위의 물리 컴포넌트 가져오기
    }

    void FixedUpdate()
    {
        diceVelocity = rb.linearVelocity; // 주사위 속도 추적 (정지했나요?)
    }

    void OnTriggerStay(Collider col)
    {
        // 주사위가 완전히 멈췄을 때만 숫자 판별
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            for (int i=0; i<6; i++){
                if (diceeyes[i].touchcheck){
                    diceResult=i+1;
                }

                Debug.Log(diceResult);

            }
            

        }

            


    }
}

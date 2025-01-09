using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class DiceCheck : MonoBehaviour

{
    Vector3 diceVelocity;
    // 주사위 속도를 저장할 벡터 선언
    void FixedUpdate() { // 호출한다 고정된 간격만큼(매 프레임x) 근데 뭔차이임 (진짜모름) (물리연산 보통 여기서?)
        diceVelocity = DiceScript.diceVelocity;
        // diceScript에서 정의한 주사위 속도 추적 (정지했는지?)
   
        

    }
    void OnTriggerStay(Collider col) //트리거 영역에 진입한 오브젝트의 콜라이더 정보 == collider col
    //실행한다 트리거 콜라이더에 오브젝트가 닿으면
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f){
            //만약 주사위 x,y,z 움직임이 0이면 ==멈추면
            // 이거 근데 왜자꾸 주사위 던질때 6으로 바뀌나요 헬프미
            switch (col.gameObject.name)// 내가 지정한 콜라이더 이름 가져와서 넣는다
            {
                case "eye1": //1눈이 바닥에 닿으면
                DiceNumberTextScript.diceNumber = 6; //호출한다 반댓면 6
                break;
                case "eye2": //이하동문임임
                DiceNumberTextScript.diceNumber = 5;
                break;
                case "eye3":
                DiceNumberTextScript.diceNumber = 4;
                break;
                case "eye4":
                DiceNumberTextScript.diceNumber = 3;
                break;
                case "eye5":
                DiceNumberTextScript.diceNumber = 2;
                break;
                case "eye6":
                DiceNumberTextScript.diceNumber = 1;
                break;
            }
        } 
    }
}


using JetBrains.Annotations;
using UnityEngine;

public class DiceScript2 : MonoBehaviour
{
    public int a=5;
    private Rigidbody rb; // 개별 주사위의 Rigidbody
    //처음꺼랑 다르게 static으로 선언 안했슴 --> static으로 하면 다 공유되서 다 똑같이 움직이고,.. 똑같은 곳에서 생성되고.. 지들끼리 부딫히고 ...으아악악
    public Vector3 diceVelocity; // 개별 주사위의 속도
    //얘도 따로 저장해야되지 않을까? 싶어서 일단 static 뻇어요

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        //가져와라 주사위 물리
    }

    void Update()
    {
        diceVelocity = rb.linearVelocity; // 현재 주사위의 속도 저장

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowDice(); // 주사위 발사사
        }
    }

    // 주사위를 던지는 함수
    void ThrowDice()
    {
        
        float dirX = Random.Range(100, 300);
        float dirY = Random.Range(100, 300);
        float dirZ = Random.Range(100, 300);
        //x,y,z 축으로 어느정도의 힘을 가할건지

        
        transform.position = new Vector3(Random.Range(-a, a), Random.Range(3, 5), Random.Range(-a, a));
        // 주사위를 랜덤 위치로 옮겨라라
        
        transform.rotation = Quaternion.identity;
        // 회전 초기화
        
        rb.AddForce(transform.up * 500);
        // 위로 힘을 줘라라

        
        rb.AddTorque(dirX, dirY, dirZ);
        // 랜덤 토크를 줘라
    }
}
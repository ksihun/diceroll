using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    // 이것은 주사위 물리다.
    // 이건 static이라 클래스 내부에서만 씀
    
    public static Vector3 diceVelocity; 
    //이것은 주사위 속도다.
    //public이라 다른곳에서 참조 가능 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //가져와라 주사위 물리
        
    }

    void Update()
    {
        diceVelocity = rb.linearVelocity;
        //rb.velocity 로 했는데 왜 바뀌나요
        //아 사라진거엿네 ㅈㅅ https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Rigidbody.html 여기 참고

        if (Input.GetKeyDown (KeyCode.Space)){
            //스페이스바를 눌러봐라
            //DiceNumberTextScript.diceNumber = 0;
            //숫자 초기화
            //초기화 하는 함수 찾아보삼 

            float dirX = Random.Range(100,300);
            float dirY = Random.Range(100,300);
            float dirZ = Random.Range(100,300);
            //x,y,z 축으로 어느정도의 힘을 가할건지

            transform.position = new Vector3(Random.Range(0,2),Random.Range(3,5),Random.Range(0,2));
            //주사위를 공중으로 옮겨라
            transform.rotation = Quaternion.identity;
            //가지고 있던 회전을 초기화해라
            rb.AddForce(transform.up * 500);
            //위로 힘을 줘라
            rb.AddTorque(dirX, dirY, dirZ);
            // x,y,z축으로 각각 토크를 줘라
        }
    }
}




//2개 던지는걸로 바꿔보려햇는데 뭔가 잘 안되요 ㅠㅠ이이
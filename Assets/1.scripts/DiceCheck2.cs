using UnityEngine;

public class DiceCheck2 : MonoBehaviour
{
    private Rigidbody rb; // 각 주사위의 Rigidbody ==> 개별 정보를 저장해야되니까... dicescript에서 가져오는거보단 여기서 다시 한번 선언하는게 나을거같아요 (아님말고)
    //이 코드는 트리거존에다 안넣고 각각 주사위에 넣을거임.
    private Vector3 diceVelocity; // 각 주사위의 속도 저장할 벡터
    public int diceResult; // 이 주사위의 결과 (1~6) =>하나일때는 그냥 바로 텍스트에다가 정보 넘겼는데 이건 일단.. 따로 저장해는게 좋을듯

    

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
            
            //주사위 판정 못하는 문제 해결하기
            switch (col.gameObject.name)
            {
                case "eye1":
                    diceResult = 6;
                    break;
                case "eye2":
                    diceResult = 5;
                    break;
                case "eye3":
                    diceResult = 4;
                    break;
                case "eye4":
                    diceResult = 3;
                    break;
                case "eye5":
                    diceResult = 2;
                    break;
                case "eye6":
                    diceResult = 1;
                    break;
            }
            


        }
    }
}
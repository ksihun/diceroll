using UnityEngine;
using TMPro;  // TextMeshPro 관련 네임스페이스 추가

public class DiceNumberTextScript : MonoBehaviour
{
    TextMeshProUGUI text;  // TextMeshProUGUI 타입으로 변수 선언
    public static int diceNumber = 0;  // 주사위 눈을 저장하는 static 변수


    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();  // TextMeshProUGUI 컴포넌트를 가져옴

        // 오류메시지를 출력해라 컴포넌트가 널이면
        if (text == null)
        {
            Debug.LogError("TextMeshProUGUI 할당하삼");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // text가 null이 아닐 경우에만 업데이트
        if (text != null)
        {
            text.text = "DICE: " + diceNumber.ToString(); 
            // 표시해라 주사위 눈화면에 문자열로 바꿔서
            // 이거 근데 왜자꾸 주사위 던질때 숫자가 6으로 바뀌나요 헬프미 ==> 해결함 ㅋㅋ
        }
        Debug.Log("DICE: " + diceNumber);
    }
}



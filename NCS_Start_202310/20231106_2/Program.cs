using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * 일정시간 후에 일을 시키기
 * 1번은 invoke
 * 2번은 co
 */
public class MatchingGame : MonoBehaviour
{
    public Text score;
    private string origStr = "";

    public Image[] ButtonImgs; // 카드뒤집기의 그림에 해당됨..

    private int[] answerArr = new int[6]; // 판별용 데이터

    public Sprite[] sprites; // 내가 세팅해줄 그림 배열

    private int rightoint = 0;

    private int tryPoint = 0;

    private int number = -1;
    
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        List<int> list = new List<int>(6) { 0, 0, 1, 1, 2, 2, };
        
        for (int i = 0; i < answerArr.Length; i++)
        {
            index = Random.Range(0, list.Count); // 0에서 list의 개수 사이 숫자를 가져옴 == index로 사용가능.
            answerArr[i] = list[index]; // list[index]에 해당하는 숫자를 answerarr배열에 차례로 넣음
            list.RemoveAt(index); // 해당 인덱스위치의 숫자를 삭제함. 겹치지 않는 배분 위함.
            ButtonImgs[i].sprite = sprites[answerArr[i]]; // 버튼 이미지들도 6개로 동일하고, 차례로 그 이미지들을 세팅할건데
            // 세팅할 이미지들을 sprites에 넣어놨고, 이 또한 배열이라서, 0,1,2 로 각 sprite에 접근가능하고,
            // answerArr[i][에 0,1,2중 숫자가 들어갔기 떄문에 가능
            
            ButtonImgs[i].gameObject.SetActive(false);
        }
    }

    public void ClickEvent(int num)
    {
        ButtonImgs[num].gameObject.SetActive(true);
        if (number == -1) // 내가 지금 선택한게 첫 선택
        {
            index = num;
        }
        else
        {
            if (answerArr[index] == answerArr[num])
            {
                rightoint++;
            }
            else
            {
                ButtonImgs[index].gameObject.SetActive(false); // 이전선택친구 뒤집기
                ButtonImgs[num].gameObject.SetActive(false); // 방금 선택친구 뒤집기
            }

            tryPoint++; // 시도횟수는 올리기
            index = -1; // 인덱스도 초기화 해주기

            score.text = $"맞춘 횟수 : {rightoint} / 시도 횟수 : {tryPoint}";
        }
    }

    void Reverse(int index1, int index2)
    {
        ButtonImgs[index1].gameObject
    }
}
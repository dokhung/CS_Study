﻿/*
 * 간이 인벤토리 만들기
 * --------------
 * 플레이어 : 이름 공격력 채력
 * 보통 플에이어가 아이템을 들고 있는 형식
 *
 
 * 아이템 보유 => 아이템 리스트를 들고 있어야함
 * 그럼 아이템 리스트를 확인하는 함수도 있어야 할것..
 *
 * 아이템 사용하는 함수 => 아이템은 내가 들고 있고
 * 내 아이템에 접근해서 그 아이템의 효과를 적용시켜야 할텐데
 * 플레이어 클래스의 사용 함수 안에서, 아이템 정보를 불러와서 내게 적용시키기
 *
 * 아이템 클래스에 나의 정보를 넘겨서 아이템 클래스의 함수에서 내 정보를 수정 시키는 방법 / 수정 된 내 정보를 받는 방법..
 *
 * => 결국 플레이어가 사용한 그 정보를 어디서 처리할 것인가의 문제
 * 정보를 주고 받을때 컴팩트하게 최소한의 필요한 정보만 주고 받고 싶다면, 구조체 내지, 일반 변수들(int, string, float....) == 값형식
 * 클래스로 주고 받기 ... 받는 쪽에서 알아서 내거 다 찾아서 알아서 적용시켜라 == 참조형식
 *==============================================================================================================
 * 
 *
 * 아이템 ( 부모 )
 * 아이템 종류 3종
 *
 * 아이템의 정보 == 아이템 이름, 가격 ,
 * 아이템의 효능 == 효능의 형태를 뭘로 할 것인지
 *
 * 검 방어구 포션 => 공격력업 / 최대 채력증가 / 현재 채력 증가
 *
 * ==============================================================================================================
 */

namespace _20231020_Mission
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
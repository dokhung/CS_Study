/*
 * 2023 10 19
 * 형변환
 * 암시적 형변환 - 명령어가 없어도 자동으로 다른 자료형으로 변환되는 경우
 * 명시적 형변환 - 강제로 다른 자료형으로 캐스티잉 가능하다. (자료형)바꿀 식;
 * 문자열 -> 숫자 : Parse() , TryParse() , Convert클래스
 * 숫자 -> 문자열 : ToString()
 * 
 */
namespace _20231019
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int intvalue = 10;
            float floatvalue = 10f;

            floatvalue = intvalue;
            intvalue = floatvalue; // int보다 float범위가 크기 떄문에 float을 작은 int안에 넣을 수는 없음

            double doublevalue = 0;

            doublevalue = floatvalue;
            floatvalue = doublevalue; // float 보다 double의 범위가 크기 떄문에 double을 float안에 넣을 수 없음
            doublevalue = intvalue; // int는 float보다 작고, float는
        }
    }
}
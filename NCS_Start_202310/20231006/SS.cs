namespace _20231006
{
    /*
     * 상속 : 다른 자식이 상속을 받을 수 있다.
     * 상속 시킬 클래스
     * 구조체 : 스트럭쳐
     * 
     */
    public enum State    // enum은 함수를 구현할수가 없다.
    {
        Idle,
        Hit,
        Dead
    }

    public struct Data
    {
        //플레이어 몬스터의 데이터 같은 데이터를 위주로 사용한다. 
        // 함수를 구현할수있다. 구조체는
        // 초기값을 가질수가 없다. 초기값이 필요하다면 함수를 따로 만들어야 한다.
        // 딜리게이트 라는거 있다니까 잊지 마슈.
        public int hp;
        public int mp;
        public int sp;
        public float speed;

        public void SetHp(int aHP)
        {
            hp = aHP;
        }

        public void init()  // 이런식으로
        {
            hp = 0;
            mp = 0;
            sp = 0;
            speed = 1;
        }
        
        // public class Data    <- 이런식으로도 됨
        // {
        //     hp = 0;
        //     mp = 0;
        //     sp = 0;
        //     speed = 1;
        // }

        // public class SS
    // {
    //     private int[] num = new int[5];
    //
    //     public int this[int x]
    //     {
    //         get { return num[x]; }
    //         set { num[x] = value; }
    //     }
    // }
    //
    // public class AA
    // {
    //     public void Main()
    //     {
    //         SS ss = new SS();
    //         ss[0] = 10;
    //     }
    // }
    // static은 바로 접근 하여 메모리에 직접적으로.. 정적으로 할당되고 프로그램이 지속되는동안 유지된다.
    // public class SS
    // {
    //     public enum State // <- 이거가 자료형이 되는거임 enum은 열거형 혹은 자료형 클래스라고 부른다.
    //     {
    //         // enum은 기본적으로 값을 설정하지 않지만 게임에서는 할수도 있다.
    //         Idle, // Idle은 4가 되는거임
    //         Move,
    //         Hit,
    //         Skill1 = 10,
    //         Skill2,
    //         Skill3,
    //         Skill4,
    //     }
    //
    //     public State state = State.Idle;
    //     // public int state = 0;

        public void Main()
        {
            Data data = new Data();
            // if (state == State.Idle)
            // {
            //     // 처리
            // }

            // int sindex = State.Skill3; // 이런식은 자료형이 안맞음
            // 정답
            // int sIndex = (int)State.Skill3;  <-- enum은 굉장히 만힝 사용합니다.


            // int sIndex = (int)State.Skill3;
            // switch ((int)state)
            // {
            //     case 1:
            //         break;
            //     case 2:
            //         break;
            //         case 3:
            //             break;
            //         case 4:
            //             break;
            // }
        }
        // 제네릭 클래스 T 를 말함
        // 모든 클래스를 담을 수 있다.
        // 싱글톤이란 디자인 패턴중 하나임 그냥 클래스
         //public List<>  여기에 자료형이랑 클래스가 들어가니까 T 가능
         // T 이거 자료형
         // public class Singleton<T> : 
         // {
         //     
         // }
         // typeof를 쓰면 그대로 리턴해줌.
         // 먼저 나오는게 큐
         // 나중에 나오는게 스택
         // 넣고 뺴고 했던거가 엔큐 디큐
         // 막대 => 빨대
         // 회사에서 var 쓰지 말라
         // foreach에선 var 쓰자. 다른곳에선 자료구조로 쓰자.
         // 다이나믹 이거 var 같은거임
         // var는 지역변수에서만 됨
         // 문자 서식
         
        
    }
}
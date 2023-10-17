using System;
using System.Collections.Generic;
//using System.Text;
//using ExtensionMethods; //확장메서드 사용용...

using System;
using System.Collections.Generic;
//using System.Text;
//using ExtensionMethods; //확장메서드 사용용...

namespace Day4
{
    #region 가벼운 TXT 게임(클래스 활용2) //실습아님

    public enum ItemType
    {
        Potion, //==0  //HP올려주는 물약
        Sword, //공격력을 올려주는 검
        Armor, //최대 HP를 올려주는 갑옷

        End
    }

    class Program
    {
        static int enemyNum = 0; //적1, 적2,... 이런식으로 증가해서 보여주기 위함..

        static void Main(string[] args)
        {
            Random random = new Random(); //랜덤 1 3 5 2 4

            Player myPlayer = new Player("나의 캐릭터", random.Next(2, 6), random.Next(10, 21)); //내 메인 플레이어 캐릭터 생성

            myPlayer.ShowMyStatus(); //내정보 일람

            string choose = ""; //선택지 입력 잠시 받아두는 용도
            while (true)
            {
                Console.WriteLine("1번 입력시 적을 찾아 떠납니다 \n 2번 입력시 아이템을 사용합니다");
                choose = Console.ReadLine();

                if (choose == "1")
                {
                    MeetEnemy(myPlayer); //적과 전투하는 함수
                }
                else if (choose == "2")
                {
                    //아이템 사용 기능 구현
                    myPlayer.UseItem();
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 게임을 종료합니다");
                    return;
                }
            }
        }

        static void MeetEnemy(Player _player) //적을 만나서 싸우기...
        {
            enemyNum += 1;//적 (숫자)
            Random random = new Random(); //MeetEnemy안에서만 쓰이는 랜덤의 선언
            Player enemy = new Player("적" + enemyNum, random.Next(1, 3), random.Next(5, 11)); //같은 Player클래스지만, 폼만 같은거고 적임..
            Console.WriteLine("========== 적을 만났습니다 ==========");
            enemy.ShowMyStatus(); //적의 정보 출력

            for (int i = 0; ; i++) //초기화식과 증감식이 있지만, 조건식이 비었기 떄문에 무한반복
            {
                if (enemy.IsAlive == false)
                {
                    Console.WriteLine("적이 사망하였습니다.");

                    //전리품 획득 //무언가 랜덤 타입의 랜덤수치 아이템을 획득함.                    
                    Item item = new Item(
                       (ItemType)random.Next(0, (int)ItemType.End),
                        random.Next(1, 6));

                    _player.SetItem(item); //아이템 사용을 합시다...                    

                    _player.ShowMyStatus(); //나의 정보 확인
                    break;
                }
                else if (_player.IsAlive == false) //적이나 내가 죽으면 이 전투를 종료
                {
                    Console.WriteLine("플레이어가 사망하였습니다");
                    break;
                }
                else //아무도 죽지 않았음
                {
                    //전투 진행
                    if (i % 2 == 0)
                    {
                        //내가 먼저 적을 공격함            
                        enemy.Attack(_player); //적의 HP를 매개변수로 들어온(플레이어)의 공격력으로 깎음
                        Console.WriteLine("내가 적을 공격하여, 적의 피가 " + enemy.HP);
                    }
                    else
                    {
                        //그다음 적이 나를 공격함
                        _player.Attack(enemy);
                        Console.WriteLine("적이 나를 공격하여, 나의 피가 " + _player.HP);
                    }
                }
            }

        }
    }

    //플레이어와 적이 있고, 아이템( 물약, 검, 갑옷)
    //물약 == HP를 일정이상, 단 최대 HP가 넘지않도록 늘려줌 / 검 == 공격력 올림 / 갑옷 == 최대HP늘림

    //플레이어 => 이름 / 공격력 / HP / 최대 HP                (+++ 레벨 + 경험치)

    //적      => 이름 / 공격력 / HP /(최대 HP)
    class Player
    {
        public Item myItem { get; private set; } = null; //변수선언

        public bool IsEnemy = false; //아군인지 적인지 여부
        string Name = "";
        int Att = 0;
        public int HP { get; private set; } = 0;
        int MaxHP = 0;

        public bool IsAlive => HP > 0; //살아있는지 여부를 알려줄겁니다

        public Player(string name, int att, int maxhp) //생성자 == 막태어났을때는 풀피일 것이기 때문에 현재 HP또한 최대체력과 동일하게 해준다.
        {
            Name = name;
            Att = att;
            MaxHP = maxhp;
            HP = maxhp;
        }
        public void SetAlliance(bool _enemy)
        {
            IsEnemy = _enemy;
        }
        public void SetItem(Item _item)
        {
            myItem = _item;
        }
        public void ShowMyStatus() //나의 스탯치를 전부 보여줌
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("공격력 : " + Att);
            Console.WriteLine("HP : " + HP + " / " + MaxHP);
            if (myItem != null)
            {
                myItem.ShowItemInfo();
            }
            Console.WriteLine("=============================\n");
        }
        //두 Attack이 동일함...
        public void Attack(int att) //매개변수로 공격력만 받기
        {
            HP -= att;
        }
        public void Attack(Player _enemy) //매개변수로 클래스를 받기
        {
            this.HP -= _enemy.Att;

            //_enemy.Attack( this.Att
            //     /*this*/ /*this 를 넣어버리면 똑같이 Player 정보를 넣게 돼서 Attack(Player _enemy ) 함수를 계속 도는 무한반복이 됨..*/ );

            //_enemy.HP -= this.Att; //만약 HP 요소가 public 으로 수정할 수 있는 사항이라면, 내가 상대방에게 피해를 입히는것도 바로 가능...
        }

        public void UseItem() //아이템 사용 함수//내가 가진 아이템을 사용하는
        {
            if (myItem == null)//아이템이 없다면
            {
                Console.WriteLine("가진 아이템이 없습니다");
            }
            else //일단 내 아이템이 존재함....
            {
                switch (myItem.itemtype)
                {
                    case ItemType.Potion: //현재 HP 를 올린다
                        HP += myItem.value;
                        if (HP > MaxHP)
                        {
                            HP = MaxHP;
                        }
                        break;
                    case ItemType.Sword:  //나의 공격력을 올린다
                        Att += myItem.value;
                        break;
                    case ItemType.Armor: //나의 최대 체력을 올린다                        
                        MaxHP += myItem.value;
                        //내가 만약 풀피였는데 최대 피통이 늘어나서 원래 피는 유지해버려서 마치 피가 깎인것같은 효과를 준다면...?
                        HP += myItem.value; //현재 체력도 동일하게 올려줌...
                        break;
                    default:
                        break;
                }
                myItem = null;

                ShowMyStatus();
            }
        }
    }
    class Item
    {
        //itemtype과 value의 값은 밖에서 맘대로 볼 수 있지만, 정보의 세팅은 생성자 에서만 가능함...
        public ItemType itemtype { get; private set; } //무슨 아이템인지
        public int value { get; private set; } = 0; //뭐가 됐건 이 아이템의 효력 수치...
        public Item(ItemType _type, int value)
        {
            itemtype = _type;
            this.value = value;
        }

        public void ShowItemInfo()
        {
            switch (itemtype)
            {
                case ItemType.Potion:
                    Console.WriteLine("이 아이템은 포션이고, " + value + "만큼 피를 회복해 줍니다");
                    break;
                case ItemType.Sword:
                    Console.WriteLine("이 아이템은 검이고, " + value + "만큼 피해를 줍니다");
                    break;
                case ItemType.Armor:
                    Console.WriteLine("이 아이템은 갑옷이고, " + value + "만큼 최대 HP를 늘려 줍니다");
                    break;
                default:
                    break;
            }
        }
    }
    #endregion

    #region N명의 정보 입력하기 (실습진행)
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //몇명을 할것인지의 N을 입력받을 것이고

    //        Console.WriteLine("몇 명의 정보를 입력하시겠습니까? ");
    //        int count = 0;
    //        if ( int.TryParse(Console.ReadLine(), out count) )
    //        {
    //            List<PersonInfo> personinfoList = new List<PersonInfo>(); //personinfo의 리스트를 쓸 준비가 됏음
    //            //PersonInfo[] personinfos = new PersonInfo[count]; //personinfo의 배열을 쓸 준비가 됏음

    //            PersonInfo _info;// = new PersonInfo();
    //            //string tmp_name="";
    //            //int tmp_age = 0;
    //            //string tmp_phone = "";

    //            for (int i = 0; i < count; i++) //count 명의 정보를 반복 입력작업 할 것임..
    //            {
    //                #region 기본생성자를 사용한 데이터 입력
    //                //1번 기본생성자 사용할 경우
    //                _info = new PersonInfo(); //하나생김    

    //                _info.SetIndex(i+1);
    //                Console.Write("이름 : ");
    //                _info.SetName(Console.ReadLine());
    //                Console.Write("나이 : ");
    //                _info.SetAge(Console.ReadLine());
    //                Console.Write("전화번호 : ");
    //                _info.SetPhone(Console.ReadLine());
    //                #endregion

    //                #region 매개변수가 있는 생성자
    //                //2번은 매개변수가 있는 생성자의 사용                    
    //                //Console.Write("이름 : ");
    //                //tmp_name = Console.ReadLine();

    //                //Console.Write("나이 : ");
    //                //int.TryParse( Console.ReadLine(), out tmp_age);

    //                //Console.Write("전화번호 : ");
    //                //tmp_phone = Console.ReadLine();

    //                //_info = new PersonInfo( i+1, tmp_name, tmp_age, tmp_phone);

    //                #endregion

    //                //personinfos[i] = _info; //배열에 넣음
    //                personinfoList.Add(_info); //리스트에 추가
    //            }

    //            Console.WriteLine("입력이 종료 되었습니다.");
    //            Console.WriteLine("알고 싶은 사람의 Index 번호를 입력해주세요");
    //            int findIndex = 0;
    //            int.TryParse(Console.ReadLine(), out findIndex);

    //            Console.WriteLine();
    //            for (int i = 0; i < personinfoList.Count; i++) //리스트에 더했을경우
    //            {
    //                personinfoList[i].ShowPersonInfo();       //조건이 없기떄문에 내가 리스트에 넣은 모든 정보를 한번씩 출력함                    
    //                Console.WriteLine();
    //            }

    //            //for (int i = 0; i < personinfos.Length; i++) //배열에 더했을경우
    //            //{
    //            //    if (personinfos[i].Index == findIndex)
    //            //    {
    //            //        personinfos[i].ShowPersonInfo();
    //            //        break;
    //            //    }
    //            //}
    //        }
    //        else
    //        {
    //            Console.WriteLine("잘못된 입력입니다");
    //            return;
    //        }



    //        //List<PersonInfo> personinfoList = new List<PersonInfo>();
    //        //PersonInfo[] personinfos = new PersonInfo[N]; //
    //        //N명의 정보 입력이 완료되면
    //        //검색하실 사람의 인덱스 번호를 입력해주세요
    //        //인덱스 번호를 찾아서
    //        //해당 클래스의 출력하기 함수

    //        //PersonInfo 형식의 리스트에 더하려면
    //        //PersonInfo 형태여야 더해짐
    //        //PersonInfo info = new PersonInfo(); //내용없는 기본 생성자 쓴 PersonInfo타입의 인스턴스

    //        //personinfoList.Add(info);
    //        //personinfos[원하는 순서] = info;

    //        //personinfoList.Add( new PersonInfo()/*이 내용을 채운~ 것을 넣어야 할 것... 혹은 후에 채우던지..*/  );
    //        //personinfos[원하는 순서] = new PersonInfo();

    //        //이런 형식
    //    }
    //}
    ////사람정보 클래스를 만들어서
    ////각자 고유 인덱스 번호를 부여하며 N명의 정보를 입력받고
    ////정보 => 이름, 나이, 전화번호
    ////입력이 끝난 후, 인덱스 번호로 검색시 해당 사람의 정보 출력하기....

    //class PersonInfo
    //{
    //    //멤버변수들을 private으로 설정할것
    //    //인덱스 => 퍼블릭 이어야 밖에서 접근 해서 확인이 가능할 것임...  //인덱스는 1번부터...
    //    public int Index { get; private set; }
    //    //이름
    //    private string name = "";
    //    //나이
    //    int age = 0;
    //    //전화번호
    //    string phonenum = "";

    //    //생성자로 생성 및 데이터 세팅 //생성자 형식        public 클래스이름()

    //    public PersonInfo() //기본 생성자
    //    {
    //    }

    //    //매개변수로 모든 멤버변수를 채우는 생성자.
    //    public PersonInfo(int index, string _name, int age, string phone)
    //    {
    //        Index = index;
    //        name = _name;
    //        this.age = age; //매개변수와 이름이 같을때에는 나의 것 == this 라고 표시를 해준다. 나의 age == this.age
    //        phonenum = phone;
    //    }


    //    //이하 각각의 멤버변수를 채우는 함수들
    //    public void SetIndex(int index)
    //    {
    //        Index = index;
    //    }

    //    public void SetName(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void SetAge(/*int age*/string age)
    //    {
    //        if (  int.TryParse(age, out this.age) == false)            
    //            Console.WriteLine("나이가 잘못 입력되었습니다");
    //    }

    //    public void SetPhone(string phonenum)
    //    {
    //        this.phonenum = phonenum;
    //    }

    //    //출력하는 함수도 만들기

    //    public void ShowPersonInfo()
    //    {
    //        Console.WriteLine($"====={Index}번 사람의 정보===== \n" +
    //            $"이름 : {name} \n" +
    //            $"나이 : {age}\n" +
    //            $"전화번호 : {phonenum}\n");
    //    }
    //}

    #endregion

}

#region 클래스
// 클래스의 구조

//필드 = 멤버변수
//속성 (property ) = 클래스의 내부 데이터를 외부에서 사용할 수 있게 혹은 외부에서 클래스 내부의 데이터를 간단하게 설정할때 사용
//int cc;
//public int CC => cc; //속성(프로퍼티)
//public int dd { get { return dd; } private set { dd = value; } } //속성 (프로퍼티)

//메서드 (함수)

//이벤트. 객체 내부의 특정상태, 어떤일이 일어났다는 것을 외부로 전달

//만들어둔 클래스(틀)를 new 하여 새로 생성한 것들이 인스턴스(내용물. 붕어빵).

#endregion

#region 확장메서드
//namespace ExtensionMethods
//{
//    public static class ExtensionMethods
//    {
//        public static bool IsEven(this int val)
//        {
//            return val % 2 == 0; //짝수인지 여부를 반환해줌..
//        }
//    }
//}

#endregion

#region 메서드(함수)

//메서드 구조

// public / protected private 같은 한정자 (필수. default로 private 상태)

//static  / sealed / abstract / override / readonly 같은 optional  //선택 옵션 없는 경우가 많다

//void / 일반 데이터 형식  을 쓰는 반환 형식 //필수. 아무것도 반환하지 않는다면 void, 정수를 반환하면 int 이런식이다

// 메서드명 (필수. 모든 것들은 이름 지어줘야 접근이 가능)

// ( 매개변수 ) // 일반 데이터형식 또는 params 같은것을 사용.


//{} 이하 괄호, 괄호안에 내용.
#endregion
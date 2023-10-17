using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission16
{
    internal class Program
    {
        /*몇명의 정보를 입력하시겠습니까?
         * 몇명을 할것인지 n을 입력받을 것이고
         *
         * n명의 정보 입력이 완료되면
         * 검색하실 사람의 인덱스번호를 입력해주세요
         * 인덱스 번호를 찾아서
         * 해당 클래스의 출력하기 함수
         * personinfoList.Add(info); PersonInfo 형식의 리스트에 더하려면  
         * personInfos[Person] = info; PersonInfo 형태여야 더해짐
         * 
         * 
         * 사람정보 클래스를 만들어서
         * 각자 고유 인덱스 번호를 부여하며 n명의 정보를 입력받고
         * 정보 => 이름, 나이, 전화번호
         * 입력이 끝난 후, 인덱스 번호로 검색시 해당 사람의 정보 출력하기
         */
        public static void Main(string[] args)
        {
            // Console.Write("몇명을 입력하시겠습니까?");
            // int Person = int.Parse(Console.ReadLine());
            // List<PersonInfo> personinfoList = new List<PersonInfo>();
            // PersonInfo[] personInfos = new PersonInfo[Person];
            // PersonInfo human1 = new PersonInfo();
            // human1.index = 1;
            // human1.name = Console.ReadLine();
            // human1.age = int.Parse(Console.ReadLine());
            // human1.phone = int.Parse(Console.ReadLine());
            // PersonInfo human2 = new PersonInfo();
            // human2.index = 2;
            // human1.name = Console.ReadLine();
            // human1.age = int.Parse(Console.ReadLine());
            // human1.phone = int.Parse(Console.ReadLine());
            // PersonInfo personInfo = new PersonInfo();
            // PersonInfo info = new PersonInfo();
            // personinfoList.Add(info);
            // personInfos[Person] = info;



            /*
             * personinfoList.Add(new PersonIno() 이 내용을 채운~ 것을 넣어야 할것 혹은 후에 채우던지
             * personinfos[원하는 순서] = new PersonInfo();
             *
             * 이런형식
             */

            Console.WriteLine("몇명의 정보를 입력하시겠습니까?");
            int count = 0;
            if (int.TryParse(Console.ReadLine(), out count))
            {
                List<PersonInfo> personinfoList = new List<PersonInfo>(); //  personinfo의 리스트를 쓸 준비가 됐음
                // PersonInfo[] personInfos = new PersonInfo[count];
                PersonInfo _info;
                // string tmp_name = "";
                // int tmp_age = 0;
                // string tmp_phone = "";
                for (int i = 0; i < count; i++) // count 명의 정보를 반복 입력작업 할 것임.
                {
                    // 1번 기본 생성자 사용 경우
                    _info = new PersonInfo(); // 하나 생김
                    _info.SetIndex(i+1);
                    Console.Write("이름 : ");
                    _info.SetName(Console.ReadLine());
                    Console.Write("나이 : ");
                    _info.SetAge(Console.ReadLine());
                    Console.Write("전화번호 : ");
                    _info.SetPhone(Console.ReadLine());
                    
                    //2번은 매개변수가 있는 생성자의 사용
                    // Console.Write("이름 : ");
                    // tmp_name = Console.ReadLine();
                    // Console.Write("나이 : ");
                    // int.TryParse(Console.ReadLine(), out tmp_age);
                    // Console.Write("전화번호 : ");
                    // tmp_phone = Console.ReadLine();

                    // _info = new PersonInfo(i + 1, tmp_name, tmp_age, tmp_phone);
                    // personInfos[i] = _info; // 배열에 넣음
                    personinfoList.Add(_info); // 리스트에 추가
                }

                Console.WriteLine("입력이 종료 되었습니다.");
                Console.WriteLine("알고 싶은 사람의 Index 번호를 입력해주세요");
                int findIndex = 0;
                int.TryParse(Console.ReadLine(), out findIndex);
                
                Console.WriteLine();
                for (int i = 0; i < personinfoList.Count; i++) // 리스트에 더했을 경우
                {
                    
                    personinfoList[i].ShowPersonInfo(); // 조건이 없기때문에 내가 리스트에 넣은 모든
                    Console.WriteLine();
                }
                
            }
            else
            {
                Console.WriteLine("잘못된 입력");
                return;
            }
        }
    }

    class PersonInfo
    {
        /*
         * 맴버변수들을 private으로 설정할것
         * 인덱스 => 퍼블릭 이어야 밖에서 접근 해서 확인이 가능할 것임
         * 인덱스는 1번부터
         * 이름
         * 나이
         * 전화번호
         */
        // public int index;
        // public string name;
        // public int age;
        // public int phone;
        //
        //
        //
        //
        // public void Persons(int index, string name,  int age, int phone)
        // {
        //     Console.WriteLine($"번호 : {this.index}");
        //     Console.WriteLine($"이름 : {this.name} ");
        //     Console.WriteLine($"나이 : {this.age} ");
        //     Console.WriteLine($"번호 : {this.phone} ");
        // }
        public int Index { get; private set; }
        private string name = "";
        private int age = 0;
        private string phonenum = "";

        public PersonInfo() // 기본 생성자
        {
            
        }
        // 매개변수로 모든 멤버변수를 채우는 생성자
        
        public PersonInfo(int index, string _name, int age, string phone)
        {
            Index = index;
            name = _name;
            this.age = age; // 매개변수와 이름이 같을떄에는 나의 것 == this 라고 표시를 해준다. 나의 age == this.age
            phonenum = phone;
        }
        //이하 각각의 맴버변수를 채우는 함수들
        public void SetIndex(int index)
        {
            Index = index;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(string age)
        {
            if (int.TryParse(age, out this.age) == false)
            
                Console.WriteLine("나이가 잘못 입력되었습니다.");
            
            // this.age = age;
        }

        public void SetPhone(string phonenum)
        {
            this.phonenum = phonenum;
        }

        
        
        public void ShowPersonInfo()
        {
            Console.WriteLine($"{Index}번 사람의 정보" + $"이름 : {name}\n" + $"나이 : {age}\n" + $"전화번호 : {phonenum}\n");
        }

    }
}
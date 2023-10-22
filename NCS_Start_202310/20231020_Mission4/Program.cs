/*
 * 애플 제품은, 해당 제품이 애플사 제품일 때에만 가능한 서비스드링 있음
 *
 * 아이폰 string 예플계정, 애플 로그인이 가능, 인터넷 사용, 통화, ios 앱을 사용
 *
 * 각각
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace _20231020_Mission4
{
    
////애플 제품은, 해당 제품이 애플사 제품일 때에만 가능한 서비스들이 있음

    ////아이폰  == string 애플계정, 애플로그인이 가능, 인터넷사용, 통화, IOS 앱을 사용
    ////맥      == string 애플계정, 애플로그인이 가능, 인터넷사용, 데스크탑 앱 사용
    ////아이패드 == string 애플계정, 애플로그인이 가능, 인터넷사용, IOS 앱을 사용하고, 펜슬 가능..

    ////이 개념들을 구현하기....
    ////====================    
    //// 공통점을.. 애플이라는 상위 클래스로 묶거나 /  ==>>>>  인터페이스를 사용하기..
    ////=================
    ////갤럭시의 경우..
    ////갤럭시     == string 삼성계정, 삼성로그인이 가능하며, 인터넷 사용 , 통화하고  안드로이드 앱을사용..
    ////삼성노트북 ==
    ////갤럭시탭   ==
    ////======================================================================

    // public enum CompanyType
    // {
    //     Apple,
    //     Samsung,
    //     
    //     End
    // }

    public class Company
    {
        
        
        public Company()
        {
            
        }
        
        
        
    }

    public class Apple : Company
    {
        // public Dictionary<string, int> AppleList = new Dictionary<string, int>();
        // AppleList.Add("Iphone",850000);
        // AppleList.Add("Ipad",2050000);
        // AppleList.Add("Iwatch",500000);
        // AppleList.Add("Ipensll",150000);
        private string[] AppleName = new String[4] { "Iphone", "Ipad", "Iwatch", "Ipensel" };
        private int[] ApplePrise = new int[4] { 850000, 2050000, 500000, 150000 };
        
        
        

        public void Login()
        {
            string AppleID = "apple123";
            string ApplePW = "apple123@";
            Console.WriteLine("Please Login");
            Console.WriteLine("Please Input Your ID");
            string AppleIDCheck = "";
            string ApplePWCheck = "";
            AppleIDCheck = Console.ReadLine();
            
            if (AppleID == AppleIDCheck)
            {
                
                Console.WriteLine("ID OK");
                Console.WriteLine("");
                Console.WriteLine("Please Your PW");
                ApplePWCheck = Console.ReadLine();
                if (ApplePWCheck == ApplePW)
                {
                    Console.WriteLine("PW OK");
                    Console.WriteLine("Login Start");
                    Console.WriteLine();
                    Console.WriteLine();
                    AppleAccess();
                }
                else
                {
                    Console.WriteLine("The PW is wrong");
                }
            }
            else
            {
                Console.WriteLine("The ID is wrong");
            }
        }
        
        

        public void AppleAccess()
        {
            // AppleList.Add("Iphone",850000);
            // AppleList.Add("Ipad",2050000);
            // AppleList.Add("Iwatch",500000);
            // AppleList.Add("Ipensll",150000);
            Console.WriteLine("This is a list of devices you are selling.");
            Console.WriteLine("Select one of the following points");
            // foreach (var item in AppleList)
            // {
            //     Console.WriteLine($"기기 : {item.Key}: {item.Value}원");
            // }
            // Console.WriteLine();
            Console.WriteLine("************************************************");
            for (int i = 0; i < AppleName.Length; i++)
            {
                Console.WriteLine($"이름 : {AppleName[i]}:{ApplePrise[i]}원");
            }
            Console.WriteLine("************************************************");
            int SeletedNum = int.Parse(Console.ReadLine());
            string PlaySelect1 = "";
            int PlaySelect2 = 0;
            if (SeletedNum == 1)
            {
                Console.WriteLine($"{AppleName[0]}이 선택되었습니다. 가격은 {ApplePrise[0]}원 입니다.");
                PlaySelect1 = AppleName[0];
                PlaySelect2 = ApplePrise[0];
                IPhone iPhone = new IPhone();
                iPhone.OnNet();
                iPhone.OnPlay();

            }
            else if (SeletedNum == 2)
            {
                Console.WriteLine($"{AppleName[1]}이 선택되었습니다. 가격은 {ApplePrise[1]}원 입니다.");
                PlaySelect1 = AppleName[1];
                PlaySelect2 = ApplePrise[1];
            }
            else if (SeletedNum == 3)
            {
                Console.WriteLine($"{AppleName[2]}이 선택되었습니다. 가격은 {ApplePrise[1]}원 입니다.");
                PlaySelect1 = AppleName[2];
                PlaySelect2 = ApplePrise[2];
            }
            else if (SeletedNum == 4)
            {
                Console.WriteLine($"{AppleName[3]}이 선택되었습니다. 가격은 {ApplePrise[3]}원 입니다.");
                PlaySelect1 = AppleName[3];
                PlaySelect2 = ApplePrise[3];
            }
            
            
        }
    }

    interface IIPhonePlay
    {
        void OnPlay();
        void OnNet();
    }
    class IPhone : Apple,IIPhonePlay
    {
        public void OnPlay()
        {
            Console.WriteLine("사용되었습니다.");
        }

        public void OnNet()
        {
            Console.WriteLine("사파리 인터넷을 사용합니다.");
        }
    }
    

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select the company you want");
            Console.WriteLine("One device from the selected enterprise is randomly created. ");
            Console.WriteLine("1. Apple  /  2. Samsung");
            int seletcompany = 0;
            seletcompany = int.Parse(Console.ReadLine());
            switch (seletcompany)
            {
               case 1:
                   Console.WriteLine("1. Apple");
                   //  해당 기업 호출
                   Apple apple = new Apple();
                   // 로그인 요구
                   apple.Login();
                   // 해당 기업의 물건중 하나 선택할 수 있도록 해야됨
                   break;
               case 2:
                   Console.WriteLine("2. Samsung");
                   //  해당 기업 호출
                   // 해당 기업의 물건중 하나 선택할 수 있도록 해야됨
                   break;
               default:
                   Console.WriteLine("Invalid input");
                   return;
            }
            
            
            
            

        }
    }
}
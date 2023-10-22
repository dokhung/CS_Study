/*
 * 애플 제품은, 해당 제품이 애플사 제품일 때에만 가능한 서비스드링 있음
 *
 * 아이폰 string 예플계정, 애플 로그인이 가능, 인터넷 사용, 통화, ios 앱을 사용
 *
 * 각각
 */

using System;
using System.Collections.Generic;

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

    public enum CompanyType
    {
        Apple,
        Samsung,
        
        End
    }
    struct LoginInfo
    {
        public CompanyType companyType;
        public string ID;
    }

    public class Company
    {
        
        public Company()
        {
            
        }
        
        
        
    }

    public class Apple : Company
    {
        
        
    }
    
    

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select the company you want");
            Console.WriteLine("One device from the selected enterprise is randomly created. ");
            Console.Write("1. Apple  /  2. Samsung");
            Console.WriteLine("");
            

        }
    }
}
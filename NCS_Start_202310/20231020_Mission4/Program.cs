/*
 * 애플 제품은, 해당 제품이 애플사 제품일 때에만 가능한 서비스드링 있음
 *
 * 아이폰 string 예플계정, 애플 로그인이 가능, 인터넷 사용, 통화, ios 앱을 사용
 *
 * 각각
 */

using System;

namespace _20231020_Mission4
{
   

    
    //**************************************************************************************
    
    
    public enum IosType
    {
        IPhone,
        MACBook,
        IPad,
        IPencil,
        
        END
    }
    
    class Ios
    {
        private string name;
        private string system;
        private string function;
        private string Class;
        
        public Ios()
        {
            
        }
        
        struct Info
        {
            private string name;
            private string system;
            private string function;
            private string Class;
        }
        

        public void PrintIos()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("dds");
            Console.WriteLine("**********************************");
        }
    }
    
    
    //**************************************************************************************
    
    
    class SANSUMG
    {
        private string name;
        private string system;
        private string function;
        private string type;
    }
    
    public enum SANSUNGType
    {
        GalaxyPhone,
        GalaxyNoteBooK,
        GalaxyTab,
        GalaxyWatch,
        GalaxyPencil,
        
        END
    }
    
    //**************************************************************************************
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*
             * new ios 생성시 랜덤으로 ios기기 아무거나 나옴
             * 삼성도 동일
             *
             * 그리고 그 기기의 기능
             * 
             */
        }
    }
}
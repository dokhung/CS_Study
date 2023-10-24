/*
 * 성적 입력하기
 * 학생들의 이름과 성적이 입력될겁니다.
 어떤 학생이 성적을 평균이 얼마고 합계가 얼마인지 빠르게 검색 가능한 코드 짜기
 */

using System;
using System.Collections.Generic;

namespace _20231024_Mission1
{
    class ScoreInfo
    {
        
    }
    public struct Score
    {
        public string name;
        public int score;

        public Score(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Score[] allScores = new Score[]
            {
                new Score("student1", 10),
                new Score("student2", 20),
                new Score("student3", 30),
                new Score("student1", 40),
                new Score("student2", 50),
                new Score("student3", 60),
                new Score("student1", 70),
                new Score("student2", 80),
                new Score("student3", 90),
            };
            
            // foreach (var VARIABLE in allScores)
            // {
            //     ScoreDic.Add(VARIABLE.name,VARIABLE.score);
            //     Console.WriteLine($"{VARIABLE.name} : {VARIABLE.score}");
            // }
            
            
            // for (int i = 0; i < allScores.Length; i++)
            // {
            //     ScoreDic.Add(allScores[i].name,allScores[i].score);
            //     CountDic.Add(allScores[i].name,count ++);
            //     // Console.WriteLine($"{allScores[i].name } : {allScores[i].score}");
            //    
            // }
            
            Dictionary<string, int> ScoreDic = new Dictionary<string, int>();
            Dictionary<string, int> CountDic = new Dictionary<string, int>();
            int count = 0;
            
            for (int i = 0; i < allScores.Length; i++)
            {
                if (ScoreDic.ContainsKey(allScores[i].name))
                {
                    ScoreDic[allScores[i].name] += allScores[i].score;
                }
                else
                {
                    ScoreDic.Add(allScores[i].name,allScores[i].score);
                }
            }
            Console.Write("검색할 학생의 이름을 입력  :  ");
            string inputstr = Console.ReadLine();
            // for (int i = 0; i < allScores[].name; i++)
            // {
                // int total = allScores[i].score + allScores[i].score + allScores[i].score;
                // double average = total / 3;
                //
                // // Console.WriteLine($"{allScores[i].name}의 평균은 {allScores[i].score}이고 총점은 {allScores[i].score}");
                // if (inputstr == allScores[i].name)
                // {
                //     
                //     Console.WriteLine($"{allScores[i].name}의 평균은 {average}이고 총점은 {total}");
                // }
                // else if (inputstr == allScores[i].name)
                // {
                //     Console.WriteLine($"{allScores[i].name}의 평균은 {average}이고 총점은 {total}");
                // }
                // else if (inputstr == allScores[i].name)
                // {
                //     Console.WriteLine($"{allScores[i].name}의 평균은 {average}이고 총점은 {total}");
                // }
                // else
                // {
                //     Console.WriteLine("없는 이름");
                // }
            // }
            
        }
    }
}
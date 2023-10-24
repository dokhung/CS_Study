/*
 * 시험기간동안 위와 같은 데이터를 이미 입력했을때
 * 원하는 학생의 이름을 입력하면
 * 모든 과목의 총점과 평균을 볼 수 있고,
 * 과목도 입력시
 * 해당 학생의 과목의 평균과 총점 또한 볼 수 있음
 * 점수가 없다면 0점
 * 과목은 국어, 영어, 수학
 */

using System;
using System.Collections.Generic;

namespace _20231024_Mission2
{

    public struct Score
    {
        public string name;
        public string subject;
        public int subjectscore;

        public Score(string name, string subject, int subjectscore)
        {
            this.name = name;
            this.subject = subject;
            this.subjectscore = subjectscore;
        }
    }

    public class ScoreInfo
    {

        public string Name = "";
        Dictionary<string, int> subjectTotalScore = new Dictionary<string, int>();
 
        public ScoreInfo(string name)
        {
            Name = name;
        }

        public void AddScore(string subject,int score)
        {
            if (subjectTotalScore.ContainsKey(subject))
            {
                subjectTotalScore[subject] += score;
            }
            else
            {
                subjectTotalScore.Add(subject,score);
            }
         
        }

        public void PrintInfo()
        {
            Console.WriteLine($"이름 : {Name}");
            Console.WriteLine($"총점 : {Total}");
            Console.WriteLine($"평균 : {Average}");
        }

    }

    internal class Program
    {
        /*
         * 시험기간동안 위와 같은 데이터를 이미 입력했을때
         * 원하는 학생의 이름을 입력하면
         * 모든 과목의 총점과 평균을 볼 수 있고,
         * 과목도 입력시
         * 해당 학생의 과목의 평균과 총점 또한 볼 수 있음
         * 점수가 없다면 0점
         * 과목은 국어, 영어, 수학
         */
        public static void Main(string[] args)
        {
            Score[] allScores = new Score[]
            {
                new Score("철수", "국어", 50),
                new Score("영희", "수학", 90),
                new Score("영수", "영어", 80),
                new Score("민희", "국어", 90),
                new Score("철수", "수학", 100),
                new Score("영수", "국어", 30),
                new Score("영희", "영어", 70),
                new Score("민희", "영어", 10),
                new Score("철수", "영어", 40),
                new Score("철수", "국어", 65),
                new Score("영희", "국어", 20),
                new Score("민희", "수학", 10),
            };

            Dictionary<string, ScoreInfo> info = new Dictionary<string, ScoreInfo>();
            

           
            foreach (var VARIABLE in allScores)
            {
                ScoreInfo sinfo = new ScoreInfo(VARIABLE.name);
                sinfo.AddScore(VARIABLE.subject,VARIABLE.subjectscore);
                info.Add(VARIABLE.name,sinfo);
            }

            Dictionary<string, int> subjectCountScore = new Dictionary<string, int>();

            Console.WriteLine("보고싶은 과목의 이름을 입력하면 해당 과목의 평균과 총점을 알려주고");
            Console.WriteLine("전부 를 입력시 전체 총점과 평균을 알려줍니다.");
            Console.WriteLine("학생의 이름을 입력하세요");
            string name = Console.ReadLine(); // 원하는 학생의 이름을 입력하면
            // 모든 과목의 총점과 평균을 볼 수 있고,
            ScoreInfo scoreInfo = new ScoreInfo(name);
            scoreInfo.PrintInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NCS_Start_202310
{
    #region 실습2

    class ScoreInfo
    {
        public string Name = ""; //학생의 이름        

        Dictionary<string, List<int>> subjectsDic = new Dictionary<string, List<int>>(); //과목, 점수들

        //"철수", "국어", 10 
        //"철수", "국어", 20 
        //"철수", "국어", 30 

        //"철수" = new List<int>(){10, 20 , 30};

        //"철수", "국어", 40 
        //"철수" = new List<int>(){10, 20 , 30, 40};

        public ScoreInfo(string name)
        {
            Name = name;
            //딕셔너리에 미리 빈 형태를 세팅한 상태
            subjectsDic.Add("국어", new List<int>());
            subjectsDic.Add("영어", new List<int>());
            subjectsDic.Add("수학", new List<int>());
        }


        public ScoreInfo(string name, string subject, int score)
        {
            Name = name;
            //딕셔너리가 완전히 빈상태로 시작.
            AddScore(subject, score);
        }

        public void AddScore(string subject, int score)
        {
            if (subjectsDic.ContainsKey(subject))
            {
                subjectsDic[subject].Add(score);
            }
            else
            {
                subjectsDic.Add(subject, new List<int>() { score });
            }
        }

        /// <summary>
        /// 매개변수로 과목명을 넘겨주면 총점반환, out 키워드로 평균을 줌
        /// </summary>
        /// <param name="subject"> 과목명 </param>
        /// <param name="Average"> 평균값 </param>
        /// <returns></returns>
        public int GetScores(string subject, out float Average) //매개변수로 과목명을 넘겨주면, 총점을 반환하고, out 키워드로 평균 줌
        {
            int total = 0; //총점

            if (string.Equals(subject, "전부"))
            {
                int allcount = 0;
                foreach (var item in subjectsDic)
                {
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        total += item.Value[i];
                    }
                    allcount += item.Value.Count;
                }
                Average = (float)total / allcount;
            }
            else
            {
                if (subjectsDic.ContainsKey(subject) == false)
                {
                    Average = 0; ///평균도 0점임
                    return 0; //총점도 0점이고
                }
                else
                {
                    for (int i = 0; i < subjectsDic[subject].Count; i++)
                    {
                        total += subjectsDic[subject][i]; // subjectsDic[subject] == List<int> 이기 때문에 [i]번째 요소 접근가능..
                    }
                    Average = (float)total / subjectsDic[subject].Count;
                }
            }
            return total;
        }

        public void PrintScore(string subject)
        {
            int total = GetScores(subject, out float aver);

            StringBuilder builder = new StringBuilder();

            builder.Append(Name).Append(" 학생의 ");

            builder.Append(string.Equals(subject, "전부") ? "총 " : subject + "과목");

            builder.Append("평균 점수는 ").Append(aver).Append("점이고 총 점수는 ")
                .Append(total).Append("점 입니다");

            Console.WriteLine(builder.ToString());
        }
    }

    public struct Score
    {
        public string name;
        public string subjects;
        public int score;
        public Score(string name, string subject, int score)
        {
            this.name = name;
            this.subjects = subject;
            this.score = score;
        }
    }

    class ScoreInfo2 //클래스로 묶어서 실습1과 비슷한 흐름...
    {
        Dictionary<string, int> subjectTotalScore = new Dictionary<string, int>(); //과목과 누적점수....
        Dictionary<string, int> subjectCountScore = new Dictionary<string, int>(); //과목과 점수를 더한 횟수..
        //public ScoreInfo2() //기본생성자.에서 아무것도 안할거면 그냥 안쓰는게 나을수도.
        //{
        //}

        public void AddScoreInfo(string subject, int score)
        {
            if (subjectTotalScore.ContainsKey(subject))
            {
                subjectTotalScore[subject] += score;
                subjectCountScore[subject]++;
            }
            else
            {
                subjectTotalScore.Add(subject, score); //세팅
                subjectCountScore.Add(subject, 1);
            }
        }

        public void PrintInfo(string subject) //정보를 보여줘...
        {
            if (string.Equals(subject, "전부"))
            {
                //전부 다 보여주는 경우
                int total = 0;
                int count = 0;
                foreach (var item in subjectTotalScore)
                {
                    total += item.Value;
                }
                foreach (var item in subjectCountScore)
                {
                    count += item.Value;
                }

                Console.WriteLine("이 학생의 총점은 " + total + "점 이고, 총 평균 점수는 " + ((float)total / count) + "입니다");
            }
            else
            {
                Console.WriteLine("이 학생의 과목 총점은 : " + subjectTotalScore[subject] + ", " +
                    "평균 점수는 " + ((float)subjectTotalScore[subject] / subjectCountScore[subject]) + " 입니다");
            }
            //과목 총점과 평균을 보여주는 경우

        }
        //public ScoreInfo2(string subject, int score) //생성을 하면서 과목과 점수를 바로 받아 넣는 경우
        //{            
        //    subjectTotalScore.Add(subject, score);
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //아래는 예시 데이터
            Score[] allScores = new Score[] {
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
                new Score("민희", "수학", 10)
            };

            #region 쉬운 방법

            ////시험기간동안 위와 같은 데이터를 이미 입력했을때
            //Dictionary<string, ScoreInfo2> studentdic = new Dictionary<string, ScoreInfo2>(); //학생이름/점수데이터덩어리 로 된 딕셔너리

            //for (int i = 0; i < allScores.Length; i++)
            //{
            //    if (studentdic.ContainsKey(allScores[i].name))
            //    {
            //        studentdic[allScores[i].name].AddScoreInfo(allScores[i].subjects, allScores[i].score);
            //    }
            //    else
            //    {
            //        ScoreInfo2 info = new ScoreInfo2();
            //        info.AddScoreInfo(allScores[i].subjects , allScores[i].score);

            //        studentdic.Add(allScores[i].name, info);
            //    }                    
            //}
            ////기본정보 끝~
            //while (true)
            //{
            //    Console.WriteLine("학생의 이름을 입력하세요");
            //    string studentname = Console.ReadLine();
            //    if (studentdic.ContainsKey(studentname) == false)
            //    {
            //        if (string.Equals(studentname, "종료"))
            //        {
            //            Console.WriteLine("프로그램을 종료합니다");
            //            return;
            //        }

            //        Console.WriteLine("잘못된 학생 이름 입니다");
            //        continue;
            //    }

            //    Console.WriteLine("보고싶은 과목의 이름을 입력하면 해당 과목의 평균과 총점을 알려주고,\n" +
            //        "\"전부\"를 입력시 해당 학생의 전체 총점과 평균을 알려줍니다");
            //    string subject = Console.ReadLine(); //과목이름을 입력받음

            //    if (string.Equals(studentname, "종료"))
            //    {
            //        Console.WriteLine("프로그램을 종료합니다");
            //        return;
            //    }

            //    studentdic[studentname].PrintInfo(subject);
            //}

            #endregion


            /////========================

            Dictionary<string, ScoreInfo> studentScoreDic = new Dictionary<string, ScoreInfo>();
            for (int i = 0; i < allScores.Length; i++)
            {
                if (studentScoreDic.ContainsKey(allScores[i].name))
                {
                    studentScoreDic[allScores[i].name].AddScore(allScores[i].subjects, allScores[i].score);
                }
                else
                    studentScoreDic.Add(allScores[i].name, new ScoreInfo(allScores[i].name, allScores[i].subjects, allScores[i].score));
            }

            //원하는 학생의 이름을 입력하면
            //모든 과목의 총점과 평균을 볼 수 있고,
            //과목도 입력시
            //해당 학생의 과목의 평균과 총점 또한 볼 수 있음
            //점수가 없다면 0점.. 
            //과목은 국어, 영어, 수학
            while (true)
            {
                Console.WriteLine("학생의 이름을 입력하세요");
                string studentname = Console.ReadLine();
                if (studentScoreDic.ContainsKey(studentname) == false)
                {
                    if (string.Equals(studentname, "종료"))
                    {
                        Console.WriteLine("프로그램을 종료합니다");
                        return;
                    }

                    Console.WriteLine("잘못된 학생 이름 입니다");
                    continue;
                }

                Console.WriteLine("보고싶은 과목의 이름을 입력하면 해당 과목의 평균과 총점을 알려주고,\n" +
                    "\"전부\"를 입력시 해당 학생의 전체 총점과 평균을 알려줍니다");
                string subject = Console.ReadLine();
                if (string.Equals(studentname, "종료"))
                {
                    Console.WriteLine("프로그램을 종료합니다");
                    return;
                }

                studentScoreDic[studentname].PrintScore(subject);
            }
        }
    }


    #endregion

    #region 실습1
    //class ScoreInfo
    //{
    //    public string Name = "";
    //    List<int> allScore = new List<int>(); //입력하는 모든 점수들 기록..
    //    public int Total { get; private set; } //총점
    //    public float Average => (float)Total / allScore.Count; //평균. 소수점을 기록하고 싶다면 int형 하나를 float이나 double로 바꿔줘야함
    //    public ScoreInfo(string name)
    //    {
    //        Name = name;            
    //    }
    //    public ScoreInfo(string name, int score)
    //    {
    //        Name = name;
    //        AddScore(score);
    //    }
    //    public void AddScore(int score)
    //    {
    //        allScore.Add(score);
    //        Total += score;
    //    }
    //    public void PrintScore()
    //    {
    //        Console.WriteLine($"{Name} 학생의 점수 평균은 { Math.Round(Average, 1)}점이고 총점은 {Total}점 입니다 ");
    //    }
    //}

    //public struct Score
    //{
    //    public string name;
    //    public int score;
    //    public Score(string name, int score)
    //    {
    //        this.name = name;
    //        this.score = score;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //무언가 데이터가       이름  성적 이 들어왔을떄
    //        //데이터가 다 쌓이고 난 후, // allScores를 다 내 데이터 분류를 끝낸 후..
    //        //학생 이름으로 검색하면, 해당학생의 평균 점수와 총점을 알 수 있음

    //        //아래는 예시 데이터
    //        Score[] allScores = new Score[] { 
    //            new Score("철수", 50), 
    //            new Score("영희", 90), 
    //            new Score("영수", 80), 
    //            new Score("민희", 90), 
    //            new Score("철수", 100), 
    //            new Score("영수", 30), 
    //            new Score("영희", 70),
    //            new Score("민희", 10), 
    //            new Score("철수", 40), 
    //            new Score("철수", 65),
    //            new Score("영희", 20) };
    //        //예시 데이터의 결과로
    //        //민희 검색시 평균은 50점이고, 총점은 100점입니다 출력
    //        //없는 이름을 검색시 잘못된 이름입니다 출력

    //        #region 가장 가벼운 형태의 딕셔너리
    //        //Dictionary<string, int> scoredic = new Dictionary<string, int>();  //총점 dictionary          
    //        //Dictionary<string, int> countdic = new Dictionary<string, int>();  //데이터를 입력한 횟수 dictionary

    //        //for (int i = 0; i < allScores.Length; i++)
    //        //{
    //        //    if (scoredic.ContainsKey(allScores[i].name))
    //        //    {
    //        //        scoredic[allScores[i].name] += allScores[i].score; //근데 이렇게 하면 누적더하기.. 즉 총점만 구할 수 있음..
    //        //        countdic[allScores[i].name] += 1;
    //        //    }
    //        //    else
    //        //    { 
    //        //        scoredic.Add(allScores[i].name, allScores[i].score ); //데이터가 없어서 새로 더함..
    //        //        countdic.Add(allScores[i].name, 1);
    //        //    }
    //        //}

    //        //Console.WriteLine("총점과 평균을 알고싶은 학생의 이름을 입력해주세요");
    //        //string Name = Console.ReadLine();

    //        //Console.WriteLine(Name + "학생의 총점 : " + scoredic[Name] + " , 평균 : " + (scoredic[Name] / countdic[Name] ) );
    //        #endregion

    //        #region 잠시 접어둠
    //        Dictionary<string, ScoreInfo> ScoreInfos = new Dictionary<string, ScoreInfo>();

    //        for (int i = 0; i < allScores.Length; i++)
    //        {
    //            if (ScoreInfos.ContainsKey(allScores[i].name))
    //            {
    //                ScoreInfos[allScores[i].name].AddScore(allScores[i].score);
    //            }
    //            else
    //            {
    //                ScoreInfos.Add(allScores[i].name, new ScoreInfo(allScores[i].name, allScores[i].score));
    //            }
    //        }
    //        //데이터 입력이 끝남...

    //        Console.WriteLine("검색할 학생의 이름을 입력해주세요");
    //        string studentname = Console.ReadLine();
    //        if (ScoreInfos.ContainsKey(studentname))
    //        {
    //            ScoreInfos[studentname].PrintScore(); //학생정보를 출력
    //        }
    //        else
    //        {
    //            Console.WriteLine("잘못된 이름입니다"); 
    //        }
    //        #endregion
    //    }
    //}

    #endregion

    #region 딕셔너리 기본
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int val = 1111;
    //        //배열 / 리스트/ 큐 스택....
    //        Dictionary<string, int> score = new Dictionary<string, int>();
    //        score.Add("아무개", val);
    //        score.Add("아무개2", val);
    //        score.Add("아무개3", 3333);

    //        score["아무개"] = 2222;                        


    //        foreach (var item in score)
    //        {
    //            Console.WriteLine("딕셔너리의 키 : " + item.Key + "딕셔너리의 값 : " +item.Value);
    //        }

    //        score.Remove("아무개2");

    //        Console.WriteLine("아무개2 삭제함");

    //        foreach (var item in score)
    //        {
    //            Console.WriteLine("딕셔너리의 키 : " + item.Key + "딕셔너리의 값 : " + item.Value);
    //        }

    //        //score.ContainsKey / score.ContainsValue 
    //    }
    //}
    #endregion
}
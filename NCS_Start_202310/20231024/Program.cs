using System;
using System.Collections.Generic;

 class ScoreInfo
    {
        public string Name = "";
        List<int> allScore = new List<int>(); //입력하는 모든 점수들 기록..
        public int Total { get; private set; } //총점
        public float Average => Total / allScore.Count; //평균
        public ScoreInfo(string name)
        {
            Name = name;            
        }

        public ScoreInfo()
        {
        }

        public ScoreInfo(string name, int score)
        {
            Name = name;
            AddScore(score);
        }
        public void AddScore(int score)
        {
            allScore.Add(score);
            Total += score;
        }
        public void PrintScore()
        {
            Console.WriteLine($"{Name} 학생의 점수 평균은 {Math.Round(Average, 1)}점이고 총점은 {Total}점 입니다 ");
        }
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

    class Program
    {
        static void Main(string[] args)
        {
            //무언가 데이터가       이름  성적 이 들어왔을떄
            //데이터가 다 쌓이고 난 후, // allScores를 다 내 데이터 분류를 끝낸 후..
            //학생 이름으로 검색하면, 해당학생의 평균 점수와 총점을 알 수 있음

            //아래는 예시 데이터
            Score[] allScores = new Score[] { 
                new Score("철수", 50), 
                new Score("영희", 90), 
                new Score("영수", 80), 
                new Score("민희", 90), 
                new Score("철수", 100), 
                new Score("영수", 30), 
                new Score("영희", 70),
                new Score("민희", 10), 
                new Score("철수", 40), 
                new Score("철수", 65),
                new Score("영희", 20) };
            //예시 데이터의 결과로
            //민희 검색시 평균은 50점이고, 총점은 100점입니다 출력
            //없는 이름을 검색시 잘못된 이름입니다 출력

            #region 가장 가벼운 형태의 딕셔너리
            //Dictionary<string, int> scoredic = new Dictionary<string, int>();  //총점 dictionary          
            //Dictionary<string, int> countdic = new Dictionary<string, int>();  //데이터를 입력한 횟수 dictionary

            //for (int i = 0; i < allScores.Length; i++)
            //{
            //    if (scoredic.ContainsKey(allScores[i].name))
            //    {
            //        scoredic[allScores[i].name] += allScores[i].score; //근데 이렇게 하면 누적더하기.. 즉 총점만 구할 수 있음..
            //        countdic[allScores[i].name] += 1;
            //    }
            //    else
            //    { 
            //        scoredic.Add(allScores[i].name, allScores[i].score ); //데이터가 없어서 새로 더함..
            //        countdic.Add(allScores[i].name, 1);
            //    }
            //}

            //Console.WriteLine("총점과 평균을 알고싶은 학생의 이름을 입력해주세요");
            //string Name = Console.ReadLine();

            //Console.WriteLine(Name + "학생의 총점 : " + scoredic[Name] + " , 평균 : " + (scoredic[Name] / countdic[Name] ) );
            #endregion

            #region 잠시 접어둠
            Dictionary<string, ScoreInfo> ScoreInfos = new Dictionary<string, ScoreInfo>();

            for (int i = 0; i < allScores.Length; i++)
            {
                if (ScoreInfos.ContainsKey(allScores[i].name))
                {
                    ScoreInfos[allScores[i].name].AddScore(allScores[i].score);
                }
                else
                {
                    //ScoreInfos.Add(allScores[i].name, new ScoreInfo(allScores[i].name, allScores[i].score));
                    ScoreInfo _info = new ScoreInfo();
                    _info.Name = allScores[i].name;
                    _info.AddScore(allScores[i].score);
                    ScoreInfos.Add(allScores[i].name, _info);
                }
            }
            //데이터 입력이 끝남...

            Console.WriteLine("검색할 학생의 이름을 입력해주세요");
            string studentname = Console.ReadLine();
            if (ScoreInfos.ContainsKey(studentname))
            {
                ScoreInfos[studentname].PrintScore(); //학생정보를 출력
            }
            else
            {
                Console.WriteLine("잘못된 이름입니다"); 
            }
            #endregion
        }
    }

    
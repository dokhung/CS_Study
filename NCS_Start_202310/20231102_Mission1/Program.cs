using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _20231102_Mission1
{
    /*
     * 당신에게 포켓몬 세마리가 있습니다. 각각 풀 불 물 타입입니다.
     * 풀은 물에게 강하고 물은 불에게 강하고 불은 풀에게 강합니다.
     * 각 포켓몬의 피는 20이상 100이하의 랜덤이고
     * 각 포켓몬의 공격력은 1이상 10이하 이빈다.
     * 같은 성질끼리 싸우면 본래 가진 공격력으로 공격하고
     * 내가 상대방에게 지는 성질이면 나의 공격력은 절반이 되고, 상대방의 공격력은 내게 공격할 떄 두배가 됩니다.
     * 포켓몬의 이름은 사용자가 입력하여 지어 줍니다. ( 후에 포켓몬 선택을 이 이름으로 합니다. )
     * 적으로 다섯마리의 포켓몬을 연달아 만나며, 각 포켓몬 또한 속성이 있습니다. (속성은 랜덤)
     * 전투가 시작되면 포켓몬을 선택하여 싸우게 할 수 있으나, 피가 0이하인 포켓몬은 선택할 수 없습니다.
     * 즉, 이전 전투에서 사망시 그 이후 전투에서 그 포켓몬은 더이상 전투 불가
     * 전투중 사망시, 남은 포켓몬 중에 골라 진행해야하며, 나의 포켓몬이 전혀 없을 경우 패배가 선언되고 게임이 아예 종료 됩니다.
     * 전투에서 승리시, 남은 포켓몬들의 정보를 전부 출력합니다.
     * 
     */
    abstract class Pokemon
    {
        public int hp;
        public int power;
        public int maxhp;
        public bool life;
        public string name;
        
        
        public abstract int Att(int enamihp, int attackpower,string enamitype);
        public abstract void info();
        public abstract void Damage();

    }

    class GrassPokemon : Pokemon
    {
        string type = "Grass";
        public GrassPokemon(int Hp, int Power, int Maxhp, bool Life, string Name)
        {
            string type = this.type;
            this.hp = Hp;
            this.power = Power;
            this.maxhp = Maxhp;
            this.life = Life;
            this.name = Name;
            

        }

        public override int Att(int enamihp, int attackpower,string enamitype)
        {
            switch (type)
            {
                case "Water":
                    power *= 2;
                    attackpower = power;
                    enamihp -= attackpower;
                    break;
                // else if(type == "Grass")
                // {
                //     power *= 1;
                // }
                case "Fire":
                    power = (int)(power*0.5f);
                    power = attackpower;
                    break;
            }
            return 0;
        }

        public override void Damage()
        {
            throw new NotImplementedException();
        }

        public override void info()
        {
            type = "Grass";
            Console.WriteLine("****************");
            Console.WriteLine($"Name : {name}/{type}");
            Console.WriteLine($"HP : {hp}/{maxhp}");
            Console.WriteLine($"Power : {power}");
            Console.WriteLine($"Life : {life}");
            Console.WriteLine("****************");
        }
    }

    class FirePokemon : Pokemon
    {
        public string type = "";
        public FirePokemon(int Hp,int Power, int Maxhp, bool Life, string Name)
        {

            string type = this.type;
            this.hp = Hp;
            this.power = Power;
            this.maxhp = Maxhp;
            this.life = Life;
            this.name = Name;

        }
        
        public override int Att(int enamihp, int attackpower,string enamitype)
        {
            if (enamitype == "Grass")
            {
                attackpower *= 2;
                Console.WriteLine("가한 데미지 = " + attackpower);
                
                
            }
            else if(enamitype == "Fire")
            {
                
                attackpower =+ 1;
                Console.WriteLine("가한 데미지 = " + attackpower);
                
            }
            else if(enamitype == "Water")
            {
                attackpower = (int)(power*0.5f);
                Console.WriteLine("가한 데미지 = " + attackpower);
                
            }

            return enamihp - attackpower;
        }
        
        public override void Damage()
        {
            throw new NotImplementedException();
        }

        public override void info()
        {
            type = "Fire";
            Console.WriteLine("****************");
            Console.WriteLine($"Name : {name}/{type}");
            Console.WriteLine($"HP : {hp}/{maxhp}");
            Console.WriteLine($"Power : {power}");
            Console.WriteLine($"Life : {life}");
            Console.WriteLine("****************");
        }
        
    }

    class WaterPokemon : Pokemon
    {
        public string type = "Water";
        public WaterPokemon(int Hp, int Power, int Maxhp, bool Life, string Name)
        {
            this.hp = Hp;
            this.power = Power;
            this.maxhp = Maxhp;
            this.life = Life;
            this.name = Name;
            string type = this.type;

        }
        
        public override int Att(int enamihp, int attackpower,string enamitype)
        {
            if (enamitype == "Fire")
            {
                power *= 2;
            }
            // else if(type == "Fire")GrassWaterFire
            // {
            //     power *= 1;
            // }
            else if(enamitype == "Fire")
            {
                power = (int)(power*0.5f);
            }
            return 0;
        }
        
        public override void Damage()
        {
            throw new NotImplementedException();
        }

        public override void info()
        {
            type = "Water";
            Console.WriteLine("****************");
            Console.WriteLine($"Name : {name}/{type}");
            Console.WriteLine($"HP : {hp}/{maxhp}");
            Console.WriteLine($"Power : {power}");
            Console.WriteLine($"Life : {life}");
            Console.WriteLine("****************");
        }
    }

    abstract class EnamyPokemon
    {
        string type = "";
        public int hp;
        public int power;
        public int maxhp;
        public bool life;
        public string name;
        
        public abstract void Att();
        public abstract void info();
        public abstract void Damage();


    }
    
    class EnamyGrassPokemon : EnamyPokemon
    {
        public string type = "Grass";
        public EnamyGrassPokemon(int Hp, int Power, int Maxhp, bool Life, string Name)
        {
            this.hp = Hp;
            this.power = Power;
            this.maxhp = Maxhp;
            this.life = Life;
            this.name = Name;
            string type = this.type;
            // int hp = Hp;
            // int power = Power;
            // int maxhp = Maxhp;
            // bool life = Life;
            // string name = Name;
        }
    
        public override void Att()
        {
            if (type == "Water")
            {
                power *= 2;
            }
            // else if(type == "Grass")
            // {
            //     power *= 1;
            // }
            else if(type == "Fire")
            {
                power = (int)(power*0.5f);
            }
        }
        
        public override void Damage()
        {
            throw new NotImplementedException();
        }
    
        public override void info()
        {
            type = "Grass";
            Console.WriteLine("****************");
            Console.WriteLine($"Name : {name}/{type}");
            Console.WriteLine($"HP : {hp}/{maxhp}");
            Console.WriteLine($"Power : {power}");
            Console.WriteLine($"Life : {life}");
            Console.WriteLine("****************");
        }
    }
    
    class EnamyFirePokemon : EnamyPokemon
    {
        public string type = "Fire";
        public EnamyFirePokemon(int Hp,int Power, int Maxhp, bool Life, string Name)
        {
            
            this.hp = Hp;
            this.power = Power;
            this.maxhp = Maxhp;
            this.life = Life;
            this.name = Name;
            string type = this.type;
    
        }
        
        public override void Att()
        {
            if (type == "Grass")
            {
                power *= 2;
            }
            // else if(type == "Fire")
            // {
            //     power *= 1;
            // }
            else if(type == "Water")
            {
                power = (int)(power*0.5f);
            }
        }
        
        public override void Damage()
        {
            throw new NotImplementedException();
        }
    
        public override void info()
        {
            type = "Fire";
            Console.WriteLine("****************");
            Console.WriteLine($"Name : {name}/{type}");
            Console.WriteLine($"HP : {hp}/{maxhp}");
            Console.WriteLine($"Power : {power}");
            Console.WriteLine($"Life : {life}");
            Console.WriteLine("****************");
        }
        
    }
    
    class EnamyWaterPokemon : EnamyPokemon
    {
        string type = "";
        public EnamyWaterPokemon(int Hp, int Power, int Maxhp, bool Life, string Name)
        {
            this.hp = Hp;
            this.power = Power;
            this.maxhp = Maxhp;
            this.life = Life;
            this.name = Name;
            string type = this.type;

        }
        
        public override void Att()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Damage()
        {
            throw new NotImplementedException();
        }
    
        public override void info()
        {
            type = "Water";
            Console.WriteLine("****************");
            Console.WriteLine($"Name : {name}/{type}");
            Console.WriteLine($"HP : {hp}/{maxhp}");
            Console.WriteLine($"Power : {power}");
            Console.WriteLine($"Life : {life}");
            Console.WriteLine("****************");
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Random random = new Random();
            int maxhp = 0;
            int power = 0;
            bool life = true;
            int hp = 0;
            int cnt = 1;
            string[] name = new string[10] { "ffo", "wwo", "ggo", "aao", "bbo", "cco", "ddo", "qqo", "cxo" ,"bmbm"};
            int randomIndex = random.Next(0, name.Length);
            string randomString = name[randomIndex];
            Console.WriteLine("포켓몬 3마리의 이름을 정하세요 ");
            Console.Write("불속성 포켓몬 이름 :  ");
            string firename = Console.ReadLine();
            Console.Write("물속성 포켓몬 이름 :  ");
            string watername = Console.ReadLine();
            Console.Write("풀속성 포켓몬 이름 :  ");
            string grassname = Console.ReadLine();
            FirePokemon firePokemon = new FirePokemon(hp, power, maxhp,life ,firename);
            WaterPokemon waterPokemon = new WaterPokemon(hp, power, maxhp,life ,watername);
            GrassPokemon grassPokemon = new GrassPokemon(hp, power, maxhp, life, grassname);
            EnamyFirePokemon enamyFirePokemon = new EnamyFirePokemon(hp, power, maxhp,life ,randomString);
            EnamyGrassPokemon enamyGrassPokemon = new EnamyGrassPokemon(hp, power, maxhp,life ,randomString);
            EnamyWaterPokemon enamyWaterPokemon = new EnamyWaterPokemon(hp, power, maxhp,life ,randomString);


            while (true)
            {
                for (int i = 0; i < cnt;)
                {
                    maxhp = random.Next(20, 100);
                    power = random.Next(1, 10);
                    hp = maxhp + 0;
                    firePokemon.hp = hp;
                    firePokemon.power = power;
                    firePokemon.maxhp = maxhp;
                    break;
                }
                for (int i = 0; i < cnt;)
                {
                    maxhp = random.Next(20, 100);
                    power = random.Next(1, 10);
                    hp = maxhp + 0;
                    waterPokemon.hp = hp;
                    waterPokemon.power = power;
                    waterPokemon.maxhp = maxhp;
                    break;
                }
                for (int i = 0; i < cnt;)
                {
                    maxhp = random.Next(20, 100);
                    power = random.Next(1, 10);
                    hp = maxhp + 0;
                    grassPokemon.hp = hp;
                    grassPokemon.power = power;
                    grassPokemon.maxhp = maxhp;
                    break;
                }
                for (int i = 0; i < cnt;)
                {
                    maxhp = random.Next(20, 100);
                    power = random.Next(1, 10);
                    hp = maxhp + 0;
                    randomIndex = random.Next(0, name.Length);
                    randomString = name[randomIndex];
                    enamyFirePokemon.name = randomString;
                    enamyFirePokemon.hp = hp;
                    enamyFirePokemon.power = power;
                    enamyFirePokemon.maxhp = maxhp;
                    break;
                }
                for (int i = 0; i < cnt;)
                {
                    maxhp = random.Next(20, 100);
                    power = random.Next(1, 10);
                    hp = maxhp + 0;
                    randomIndex = random.Next(0, name.Length);
                    randomString = name[randomIndex];
                    enamyGrassPokemon.name = randomString;
                    enamyGrassPokemon.hp = hp;
                    enamyGrassPokemon.power = power;
                    enamyGrassPokemon.maxhp = maxhp;
                    break;
                }
                for (int i = 0; i < cnt;)
                {
                    maxhp = random.Next(20, 100);
                    power = random.Next(1, 10);
                    hp = maxhp + 0;
                    randomIndex = random.Next(0, name.Length);
                    randomString = name[randomIndex];
                    enamyWaterPokemon.name = randomString;
                    enamyWaterPokemon.hp = hp;
                    enamyWaterPokemon.power = power;
                    enamyWaterPokemon.maxhp = maxhp;
                    break;
                }
                
                Bettleinfo();
                break;
                
            }
            
            void Bettleinfo()
            {
                Console.WriteLine("자신의 포켓몬");
                firePokemon.info();
                waterPokemon.info();
                grassPokemon.info();
                Console.Write("확인 완료되었으면 배틀 시작? : Y/N ===== ::::  ");
                string selestr = Console.ReadLine();
                switch (selestr)
                {
                    case "Y":
                        Console.WriteLine("ok");
                        BettleSelrect();
                        break;
                    case "N":
                        Console.WriteLine("취소");
                        Bettleinfo();
                        break;
                }
            }

             void BettleSelrect()
            {
                Console.WriteLine("너가 내보낼 포켓몬은? ");
                Console.WriteLine($"1.{firename}");
                Console.WriteLine($"2.{watername}");
                Console.WriteLine($"3.{grassname}");
                int selnum = int.Parse(Console.ReadLine());
                if (selnum == 1)
                {
                    Console.WriteLine("내보낼 포켓몬의 정보");
                    firePokemon.info();
                    BettleStart(selnum);
                }
                else if (selnum == 2)
                {
                    Console.WriteLine("내보낼 포켓몬의 정보");
                    waterPokemon.info();
                    BettleStart(selnum);
                }
                else if (selnum == 3)
                {
                    Console.WriteLine("내보낼 포켓몬의 정보");
                    grassPokemon.info();
                    BettleStart(selnum);
                }
            }

             

             void BettleStart(int selnum)
             {
                 if (selnum == 1)
                 {
                     while (true)
                     {
                         Console.WriteLine("당신의 공격차례입니다. 공격하겠습니까??");
                         Console.Write("선택하라 : Y/N ");
                         string ok = Console.ReadLine();
                         int enamihp = enamyFirePokemon.hp;
                         int pokemonpower = firePokemon.power;
                         string enamitype = enamyFirePokemon.type;
                         if (ok == "Y")
                         {
                             Console.WriteLine("상대채력 확인(전)"+enamihp);
                             firePokemon.Att(enamihp,pokemonpower,enamitype);
                             Console.WriteLine($"타격데미지 : {pokemonpower}");
                             Console.WriteLine($"남은 채력{enamihp - pokemonpower}");
                             int _enamihp = enamihp - pokemonpower;
                             Console.WriteLine("상대채력 확인(후)"+_enamihp);
                             enamyFirePokemon.info();
                         }
                     }  
                 }
                 else if (selnum == 2)
                 {
                     while (true)
                     {
                         Console.WriteLine("떄릴꼬얌?");
                         Console.Write("선택하라 : Y/N ");
                         string ok = Console.ReadLine();
                         int enamihp = enamyWaterPokemon.hp;
                         int pokemonpower = waterPokemon.power;
                         string enamitype = enamyFirePokemon.type;
                         if (ok == "Y")
                         {
                             waterPokemon.Att(enamihp,pokemonpower,enamitype);
                         }
                     }   
                 }
                 else if (selnum == 3)
                 {
                     while (true)
                     {
                         Console.WriteLine("떄릴꼬얌?");
                         Console.Write("선택하라 : Y/N ");
                         string ok = Console.ReadLine();
                         int enamihp = grassPokemon.hp;
                         int pokemonpower = grassPokemon.power;
                         string enamitype = enamyFirePokemon.type;
                         if (ok == "Y")
                         {
                             grassPokemon.Att(enamihp,pokemonpower,enamitype);
                             
                         }
                     }   
                 }
             }

        }

        
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        List<Pokemon> myPokemon = new List<Pokemon>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"포켓몬 {i + 1}의 이름을 입력하세요: ");
            string name = Console.ReadLine();
            string type = GetRandomPokemonType();
            int hp = random.Next(20, 101);
            int power = random.Next(1, 11);

            if (type == "불")
                myPokemon.Add(new FirePokemon(name, hp, power));
            else if (type == "물")
                myPokemon.Add(new WaterPokemon(name, hp, power));
            else if (type == "풀")
                myPokemon.Add(new GrassPokemon(name, hp, power));
        }

        List<EnamyPokemon> enamyPokemon = new List<EnamyPokemon>();

        for (int i = 0; i < 5; i++)
        {
            string type = GetRandomPokemonType();
            string name = $"적 포켓몬 {i + 1}";
            int hp = random.Next(20, 101);
            int power = random.Next(1, 11);

            if (type == "불")
                enamyPokemon.Add(new EnamyFirePokemon(name, hp, power));
            else if (type == "물")
                enamyPokemon.Add(new EnamyWaterPokemon(name, hp, power));
            else if (type == "풀")
                enamyPokemon.Add(new EnamyGrassPokemon(name, hp, power));
        }

        int currentPokemonIndex = 0;
        int defeatedPokemonCount = 0;

        while (currentPokemonIndex < myPokemon.Count)
        {
            Pokemon currentPokemon = myPokemon[currentPokemonIndex];
            if (currentPokemon.IsAlive())
            {
                Console.WriteLine($"현재 포켓몬: {currentPokemon.Name}");
                Console.WriteLine("싸울 적 포켓몬을 선택하세요:");

                for (int i = 0; i < enamyPokemon.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {enamyPokemon[i].Name} ({enamyPokemon[i].Type})");
                }

                int enemyIndex = int.Parse(Console.ReadLine()) - 1;
                if (enemyIndex >= 0 && enemyIndex < enamyPokemon.Count)
                {
                    EnamyPokemon enemyPokemon = enamyPokemon[enemyIndex];

                    Battle(currentPokemon, enemyPokemon);

                    if (!enemyPokemon.IsAlive())
                    {
                        Console.WriteLine($"{enemyPokemon.Name}를 처치하였습니다!");
                        enamyPokemon.RemoveAt(enemyIndex);
                        defeatedPokemonCount++;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 적 선택입니다.");
                }
            }

            currentPokemonIndex++;

            if (currentPokemonIndex < myPokemon.Count)
            {
                Console.WriteLine("다음 포켓몬으로 계속하려면 Enter 키를 누르세요.");
                Console.ReadLine();
            }
        }

        if (defeatedPokemonCount == 5)
        {
            Console.WriteLine("축하합니다! 모든 적 포켓몬을 처치하였습니다.");
        }
        else
        {
            Console.WriteLine("사용 가능한 포켓몬이 모두 소진되었습니다. 게임 종료.");
        }
    }

    static void Battle(Pokemon attacker, EnamyPokemon defender)
    {
        Console.WriteLine($"{attacker.Name} (속성: {attacker.Type})이(가) {defender.Name} (속성: {defender.Type})을(를) 공격합니다!");
        int damage = attacker.Attack();
        Console.WriteLine($"입힌 데미지: {damage}");
        defender.TakeDamage(damage);
        Console.WriteLine($"{defender.Name} (속성: {defender.Type})의 남은 체력: {defender.HP}");
    }

    static string GetRandomPokemonType()
    {
        string[] types = { "불", "물", "풀" };
        int randomIndex = random.Next(0, types.Length);
        return types[randomIndex];
    }
}

abstract class Pokemon
{
    public string Name { get; }
    public int HP { get; protected set; }
    public int Power { get; }
    public string Type { get; }

    public Pokemon(string name, int hp, int power, string type)
    {
        Name = name;
        HP = hp;
        Power = power;
        Type = type;
    }

    public int Attack()
    {
        return Power;
    }

    public bool IsAlive()
    {
        return HP > 0;
    }
}

class FirePokemon : Pokemon
{
    public FirePokemon(string name, int hp, int power) : base(name, hp, power, "불") { }
}

class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, int hp, int power) : base(name, hp, power, "물") { }
}

class GrassPokemon : Pokemon
{
    public GrassPokemon(string name, int hp, int power) : base(name, hp, power, "풀") { }
}


abstract class EnamyPokemon
{
    public string Name { get; }
    public int HP { get; protected set; }
    public int Power { get; }
    public string Type { get; }

    public EnamyPokemon(string name, int hp, int power, string type)
    {
        Name = name;
        HP = hp;
        Power = power;
        Type = type;
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP < 0)
            HP = 0;
    }

    public bool IsAlive()
    {
        return HP > 0;
    }
}

class EnamyFirePokemon : EnamyPokemon
{
    public EnamyFirePokemon(string name, int hp, int power) : base(name, hp, power, "Fire") { }
}

class EnamyWaterPokemon : EnamyPokemon
{
    public EnamyWaterPokemon(string name, int hp, int power) : base(name, hp, power, "Water") { }
}

class EnamyGrassPokemon : EnamyPokemon
{
    public EnamyGrassPokemon(string name, int hp, int power) : base(name, hp, power, "Grass") { }
}

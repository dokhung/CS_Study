using System;
using System.Collections.Generic;

class Pokemon
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }

    public Pokemon(string name, string type)
    {
        Name = name;
        Type = type;
        HP = new Random().Next(20, 101);
        Attack = new Random().Next(1, 11);
    }

    public void AttackOpponent(Pokemon opponent)
    {
        double damageMultiplier = 1.0;
        
        if (Type == "풀" && opponent.Type == "물" || 
            Type == "물" && opponent.Type == "불" || 
            Type == "불" && opponent.Type == "풀")
        {
            damageMultiplier = 2.0;
        }
        else if (Type == opponent.Type)
        {
            damageMultiplier = 0.5;
        }
        
        int damage = (int)(Attack * damageMultiplier);
        opponent.HP -= damage;
        
        Console.WriteLine($"{Name}이(가) {opponent.Name}에게 {damage}의 피해를 입혔습니다.");
    }
}

class Program
{
    static void Main()
    {
        List<Pokemon> myPokemons = new List<Pokemon>();
        List<Pokemon> enemyPokemons = new List<Pokemon>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"포켓몬 {i + 1}의 이름을 입력하세요: ");
            string name = Console.ReadLine();
            string type = new Random().Next(1, 4) switch
            {
                1 => "풀",
                2 => "물",
                3 => "불",
                _ => "풀",
            };
            Pokemon pokemon = new Pokemon(name, type);
            myPokemons.Add(pokemon);
        }

        for (int i = 0; i < 5; i++)
        {
            string type = new Random().Next(1, 4) switch
            {
                1 => "풀",
                2 => "물",
                3 => "불",
                _ => "풀",
            };
            enemyPokemons.Add(new Pokemon($"적 포켓몬 {i + 1}", type));
        }

        while (myPokemons.Count > 0 && enemyPokemons.Count > 0)
        {
            Pokemon myPokemon = SelectPokemon(myPokemons);
            Pokemon enemyPokemon = SelectPokemon(enemyPokemons);

            if (myPokemon == null || enemyPokemon == null)
            {
                Console.WriteLine("포켓몬을 선택할 수 없습니다. 게임 종료!");
                break;
            }

            myPokemon.AttackOpponent(enemyPokemon);

            if (enemyPokemon.HP <= 0)
            {
                Console.WriteLine($"{enemyPokemon.Name}을(를) 물리쳤습니다!");
                enemyPokemons.Remove(enemyPokemon);
            }
            else
            {
                enemyPokemon.AttackOpponent(myPokemon);

                if (myPokemon.HP <= 0)
                {
                    Console.WriteLine($"{myPokemon.Name}이(가) 패배했습니다.");
                    myPokemons.Remove(myPokemon);
                }
            }
        }

        if (myPokemons.Count > 0)
        {
            Console.WriteLine("게임에서 승리했습니다! 나의 포켓몬 정보:");
            foreach (var pokemon in myPokemons)
            {
                Console.WriteLine($"이름: {pokemon.Name}, 속성: {pokemon.Type}, 체력: {pokemon.HP}, 공격력: {pokemon.Attack}");
            }
        }
        else
        {
            Console.WriteLine("게임에서 패배했습니다. 적 포켓몬이 이겼습니다.");
        }
    }

    static Pokemon SelectPokemon(List<Pokemon> pokemons)
    {
        Console.WriteLine("사용 가능한 포켓몬:");
        for (int i = 0; i < pokemons.Count; i++)
        {
            Console.WriteLine($"{i + 1}. 이름: {pokemons[i].Name}, 속성: {pokemons[i].Type}, 체력: {pokemons[i].HP}, 공격력: {pokemons[i].Attack}");
        }

        Console.Write("포켓몬을 선택하세요 (1, 2, 3) 또는 취소 (0): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 0)
        {
            return null;
        }
        else if (choice >= 1 && choice <= pokemons.Count)
        {
            return pokemons[choice - 1];
        }
        else
        {
            Console.WriteLine("잘못된 선택입니다. 다시 선택하세요.");
            return SelectPokemon(pokemons);
        }
    }
}
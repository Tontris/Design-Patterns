using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GameCharacterBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення героя
            HeroBuilder heroBuilder = new HeroBuilder();
            CharacterDirector director = new CharacterDirector(heroBuilder);
            director.ConstructHero();
            Character hero = heroBuilder.Build();

            Console.WriteLine("Hero:");
            hero.DisplayInfo();

            Console.WriteLine();

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            director = new CharacterDirector(enemyBuilder);
            director.ConstructEnemy();
            Character enemy = enemyBuilder.Build();

            Console.WriteLine("Enemy:");
            enemy.DisplayInfo();
        }
    }
}
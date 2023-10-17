﻿using System;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }
    
    

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();
            
            Console.WriteLine("Creating IrorMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();
            
            Console.WriteLine("Creating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
            

        }
    }
}
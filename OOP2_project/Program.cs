using System;

namespace OOP2_project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hero assassin = new Mage("Fighter 1", 1500, 100, 100);
            Hero warrior = new Warrior("Fighter 2", 2000, 120, 110);
            
            GameEngine engine = new GameEngine(assassin, warrior);
            engine.start();
        }
    }
}

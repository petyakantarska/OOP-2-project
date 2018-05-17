using System;
namespace OOP2_project
{
    public class GameEngine
    {
        private Hero heroOne, heroTwo;
        private bool isFirstHeroTurn;
        private int turnsCount = 1;

        public GameEngine(Hero heroOne, Hero heroTwo)
        {
            this.heroOne = heroOne;
            this.heroTwo = heroTwo;
        }

        public void start() {
            Console.WriteLine("## LETS BEGIN! ##");
            Console.WriteLine("## FIGHT! ## \n");

            while(true)
            {
                Console.WriteLine("## TURN " + turnsCount + " ##");

                if (isFirstHeroTurn == true) 
                {
                    heroOne.fight(heroTwo);
                    isFirstHeroTurn = false;
                } else {
                    heroTwo.fight(heroOne);
                    isFirstHeroTurn = true;
                }

                Console.WriteLine("\nResults: ");
                Console.WriteLine(heroOne.getName() + "'s Health: " + heroOne.getHealth());
                Console.WriteLine(heroTwo.getName() + "'s Health: " + heroTwo.getHealth());
                Console.WriteLine();

                if (heroOne.isDead())
                {
                    Console.WriteLine("GAME ENDS!");
                    Console.WriteLine("Hero " + heroTwo.getName() + " WINS in " + turnsCount + " turns!");
                    break;
                }
                else if (heroTwo.isDead())
                {
                    Console.WriteLine("GAME ENDS!");
                    Console.WriteLine("Hero " + heroOne.getName() + " WINS in " + turnsCount + " turns!");
                    break;
                }

                turnsCount += 1;
            }
        }
    }
}

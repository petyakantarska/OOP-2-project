using System;
namespace OOP2_project
{
    public class Knight: Hero
    {
        public Knight(string name, int healthPoints, int attackPoints, int defendPoints)
            : base(name, healthPoints, attackPoints, defendPoints)
        {
        }

        override public void fight(Hero opponent)
        {
            int damage = base.getAttackDamage();

            Random random = new Random();
            if (random.Next(1, 101) <= 10) 
            {
                damage += damage * 200 / 100;
            }

            Console.WriteLine(name + " attacks " + opponent.getName() + " dealing " + damage + " damage!");
            opponent.defend(this, damage);
        }

        public override void defend(Hero opponent, int damage)
        {
            int receivedDamage = damage - getDefendDamage();
            if (receivedDamage <= 0) receivedDamage = 0;

            Random random = new Random();
            if (random.Next(1, 101) <= 20)
            {
                receivedDamage = 0;
                Console.WriteLine(name + " BLOCKS the attack and receive " + receivedDamage + " damage!");
            }
            else
            {
                Console.WriteLine(name + " receives " + receivedDamage + " damage!");
                base.receiveDamage(receivedDamage);
            }
        }
    }
}

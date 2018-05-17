using System;
namespace OOP2_project
{
    public class Mage: Hero
    {
        public Mage(string name, int healthPoints, int attackPoints, int defendPoints)
            : base(name, healthPoints, attackPoints, defendPoints)
        {
        }

        public override void fight(Hero opponent)
        {
            int damage = base.getAttackDamage();

            // There's a 25% chance to deal 250% damage
            Random random = new Random();
            if (random.Next(1, 101) <= 25) 
            {
                damage += damage * 250 / 100;
            }

            Console.WriteLine(name + " attacks " + opponent.getName() + " dealing " + damage + " damage!");
            opponent.defend(this, damage);
        }

        public override void defend(Hero opponent, int damage)
        {
            int receivedDamage = damage - getDefendDamage();
            if (receivedDamage <= 0) receivedDamage = 0;

            // There's a 15% to block and deal back 150% damage
            Random random = new Random();
            if (random.Next(1, 101) <= 15) 
            {
                receivedDamage = 0;
                int returnDamage = base.getAttackDamage() + (base.getAttackDamage() * 200 / 100);
                Console.WriteLine(name + " BLOCKS the attack and receive " + receivedDamage + " damage! Deal back " +
                                  returnDamage + " damage.");
                opponent.defend(this, returnDamage);
            }
            else
            {
                Console.WriteLine(name + " receives " + receivedDamage + " damage!");
                base.receiveDamage(receivedDamage);
            }
        }
    }
}

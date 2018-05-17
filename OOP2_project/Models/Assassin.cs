using System;
namespace OOP2_project
{
    public class Assassin : Hero
    {
        
        public Assassin(string name, int healthPoints, int attackPoints, int defendPoints)
            : base(name, healthPoints, attackPoints, defendPoints) 
        {
        }

        override public void fight(Hero opponent) 
        {
            int damage = getAttackDamage();

            Random random = new Random();
            int chance = random.Next(0, 100);

            if (chance <= 30) {
                damage += damage * 200 / 100;
            }

            Console.WriteLine(name + " attacks " + opponent.getName() + " dealing " + damage + " damage!");
            opponent.defend(this, damage);
        }

		public override void defend(Hero opponent, int damage)
		{
            int receivedDamage = damage - getDefendDamage();
            if (receivedDamage <= 0) receivedDamage = 0;
            Console.WriteLine(name + " receives " + receivedDamage + " damage!");

            base.receiveDamage(receivedDamage);
		}
	}
}

﻿using System;
namespace OOP2_project
{
    public class Warrior: Hero
    {
        public Warrior(string name, int healthPoints, int attackPoints, int defendPoints)
            : base(name, healthPoints, attackPoints, defendPoints)
        {
        }

        override public void fight(Hero opponent)
        {
            int damage = base.getAttackDamage();
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

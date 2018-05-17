using System;
namespace OOP2_project
{
    public abstract class Hero
    {
        protected string name;
        protected int healthPoints;
        protected int attackPoints;
        protected int defendPoinds;

        private Random random = new Random();

        public Hero(string name, int healthPoints, int attackPoints, int defendPoints)
        {
            this.name = name;
            this.healthPoints = healthPoints;
            this.attackPoints = attackPoints;
            this.defendPoinds = defendPoints;
        }

        protected int getAttackDamage()
        {
            int damage = random.Next((int)(attackPoints * 0.8), (int)(attackPoints * 1.2));
            return (damage > 0) ? damage : 0;
        }

        protected int getDefendDamage() {
            int damage = random.Next((int) (defendPoinds * 0.8), (int)(defendPoinds * 1.2));
            return (damage > 0) ? damage : 0;
        }

        public abstract void fight(Hero opponent);

        public abstract void defend(Hero opponent, int damage);

        protected void receiveDamage(int damage) {
            healthPoints -= damage;
            if (healthPoints < 0) healthPoints = 0;
        }

        public String getName()
        {
            return name;
        }

        public int getHealth()
        {
            return healthPoints;
        }

        public Boolean isDead() {
            return healthPoints <= 0;
        }
    }
}

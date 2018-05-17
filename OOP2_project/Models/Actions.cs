using System;
namespace OOP2_project
{
    public interface Actions
    {
        void fight(Hero hero, int damage);
        void receiveDamage(int damage);
    }
}

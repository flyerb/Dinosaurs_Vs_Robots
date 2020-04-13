using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Dinosaur
    {
        //member variables

        public string type;
        public double health;
        public double energy;
        public double attackPower;


        //ctor

        public Dinosaur(string type, double attackPower)
        {
            this.type = type;
            health = 100;
            energy = 100;
            this.attackPower = attackPower;
        }

        //member methods

        public void DinoCharge() 
        {
            if (energy > 0)
            {
                double newEnergy = energy - 50;
                energy = newEnergy;
                double newAttackPower = attackPower - 2;
                attackPower = newAttackPower;
                double battleHealth = health - 10;
                health = battleHealth;
                Console.WriteLine("Dino Energy level " + newEnergy.ToString());
                Console.WriteLine("Dino Attack Power " + newAttackPower.ToString());
            }
            else
            {
                double battleHealth = health - 5;
                health = battleHealth;
                Console.WriteLine("Dino too tired to fight back :(");
            }
        }

        public void DinoAttack()
        {
            if (health > 0)
            {
                DinoCharge();
            }
            else
            {
                Console.WriteLine("Dino is dead.");
            }
        }
        

    }
}

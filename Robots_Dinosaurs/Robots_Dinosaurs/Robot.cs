using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Robot
    {
        // name, health, power level, and a Weapon with a type (i.e. sword) and attack power

        // member variables

        public string name;
        public double health;
        public double powerLevel;
        public Weapon weapon; 
        public double attackPower;

        //Ctor
        public Robot(string name, double attackPower)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            weapon = new Weapon();
            this.attackPower = attackPower;
        }

        //Member methods
        public void RobotCharge()
        {
            if(powerLevel > 10 )
            {
                double newPowerLevel = powerLevel - 50;
                powerLevel = newPowerLevel;
                double newAttackPower = attackPower - 2;
                attackPower = newAttackPower;
                double battleHealth = health - 45;
                health = battleHealth;
                Console.WriteLine("Robot Power Level " + newPowerLevel.ToString());
                Console.WriteLine("Robot Attack power " + newAttackPower.ToString());
                Console.WriteLine("Robot health is " + battleHealth.ToString());
            }
            else
            {
                double battleHealth = health - 10;
                health = battleHealth;
                Console.WriteLine("Robot too tired to fight back :(");
                
            }
            

           
            //make a random number between attack power - that number against herd.dinosaur.health
        }

        public void RobotAttack()//two objects passed in.
        {
            if (health > 0)
            {
                RobotCharge();
            }
            else
            {
                Console.WriteLine("Robot is dead.");
            }
        }
        

    }
}

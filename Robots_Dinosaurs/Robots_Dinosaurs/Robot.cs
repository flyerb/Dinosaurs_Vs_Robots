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
   
        // can attack will subtract attack power from powerlevel and will lower attack power by 10 - if power level reaches 0- cant attack
        public void RobotCharge() // Do I have to name this differently? Or can dino have it's own Charge too?
        {
            if(powerLevel > 10 )
            {
                //attackPower - Dinosaur.health; how do I pick a specific dino?
                double newPowerLevel = powerLevel - 50;
                powerLevel = newPowerLevel;
                double newAttackPower = attackPower - 2;
                attackPower = newAttackPower;
                //double depeltedPower = powerLevel - attackPower;
                //attackPower = depeltedPower;
                Console.WriteLine("Robot" + newPowerLevel.ToString());
                Console.WriteLine("Robot" + newAttackPower.ToString());


            }
            else
            {
                Console.WriteLine("To tired to fight back :(");
                
            }
            

           
            //make a random number between attack power - that number against herd.dinosaur.health
        }

        public void RobotAttack()
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

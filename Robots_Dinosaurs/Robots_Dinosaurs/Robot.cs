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
        public double Charge()
        {
            if(powerLevel > 0 )
            {
                //attackPower - Dinosaur.health; how do I pick a specific dino?
                double depeltedPower = powerLevel - attackPower;
                return depeltedPower;
            }
            else
            {
                Console.WriteLine("To tired to fight back :(");
                return 0;
            }
            

           
            //make a random number between attack power - that number against herd.dinosaur.health
        }

        public void Attack()
        {
            if (health > 0 && powerLevel > 0)
            {
                Charge();
            }
            else
            {
                Console.WriteLine("Robot is dead.");
            }
        }
        

    }
}

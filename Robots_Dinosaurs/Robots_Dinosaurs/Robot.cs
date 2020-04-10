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
        public string weapon;
        public double attackPower;

        //Ctor
        public Robot(string name, string weapon, double attackPower)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            this.weapon = weapon;
            this.attackPower = attackPower;
        }

        //Member methods

        // 1) A way to be chosen for battle? An array of dino/Robots? index[0] fights index [0]? Method for fleet/herd?

        // 2)can attack   3) be attacked   4) if power level or health = 0 they die    

        // can attack will subtract attack power from powerlevel and affects their attack power
        public double Attack()
        {
            return attackPower - powerLevel;
        }

        //Subtract health from a dinosaur after an attack

        public void SuccessfulAttack()
        {
            //after robot.attack - dinosaur.health....
        }

        //while loop. While health or power level > 0 Attack() when 0 C.WL "name" is dead

        public void StillFight()
        {
            if (health > 0 && powerLevel > 0)
            {
                // return to fight
            }
            else
            {
                Console.WriteLine(" Robot name is dead.");
            }
        }
        

    }
}

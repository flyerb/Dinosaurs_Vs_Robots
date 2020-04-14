using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Battlefield
    {
        public Fleet warBots = new Fleet();
        public Herd warHerd = new Herd();
        public void StartFight()
        {
            
            //Optionn one
            //while (warBots.robotFleet[0].health > 0 && warHerd.dinoOne.health >=0)
            //{
            //    warBots.robotFleet[0].RobotAttack();
            //    warHerd.dinoOne.DinoAttack();
            //    Console.Write("Is the Robot dead? Y/N");
            //    string userinput = Console.ReadLine();
            //    if(userinput == "Y")
            //    {
            //        warBots.robotFleet[1].RobotAttack();
            //    }
            //}


            //Option Two without Robot List
            //while (warBots.robotOne.health >= 0 && warHerd.dinoOne.health >= 0)
            //{
            //    warBots.robotOne.RobotAttack();
            //    warHerd.dinoOne.DinoAttack();
            //}
            //else if(warBots.robotOne.health == 0)
            //{
            //    warBots.robotTwo.RobotAttack();
            //}
            //else if (warHerd.dinoOne.health == 0)
            //{
            //    warHerd.dinoTwo.DinoAttack();
            //}


        }
    }
}

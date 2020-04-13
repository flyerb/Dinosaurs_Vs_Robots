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
            if (warBots.robotOne.health >= 0 || warHerd.dinoOne.health >= 0)
            {
                warBots.robotOne.RobotAttack();
                warHerd.dinoOne.DinoAttack();
            }
            else if(warBots.robotOne.health == 0)
            {
                warBots.robotTwo.RobotAttack();
            }
            else if (warHerd.dinoOne.health == 0)
            {
                warHerd.dinoTwo.DinoAttack();
            }


        }
    }
}

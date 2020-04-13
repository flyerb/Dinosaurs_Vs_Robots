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
            //warBots initiate fight 
            while(warBots.robotOne.powerLevel > 0 && warHerd.dinoOne.energy > 0)
            {
                warBots.robotOne.RobotCharge();
                warHerd.dinoOne.DinoCharge();
            }
        }

        // think of fist example. when one opponent dies, the next opponent comes to finish him off
    }
}

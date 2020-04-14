using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Fleet
    {
        public Robot robotOne = new Robot("Cylon", 40);
        public Robot robotTwo = new Robot("Bender", 20);
        public Robot robotThree = new Robot("Wall-E", 10);

        public List<Robot> robotFleet = new List<Robot>();
        public Fleet()
        {
            robotFleet = new List<Robot>() { robotOne, robotTwo, robotThree };
        }


        //methods  - 1) A way to be chosen for battle? An array of Robots  R-index[0] fights D-index [0]? 
        public void yourTurn()
        {
            for (int i = 0; i < robotFleet.Count; i++)
            {
               
            }

            //foreach (Robot robo in robotFleet)
            //{
            //    if(robotOne.health == 0)
            //    {
            //        robo.next();
            //    }
            //    else if(robotTwo.health == 0)
            //{

            //    }
            //    else if(robotThree.health == 0)
            //    {

            //    }
            }
        }
        

        // When all robots are dead C.WL("Dinosaurs win")


    }

   
 

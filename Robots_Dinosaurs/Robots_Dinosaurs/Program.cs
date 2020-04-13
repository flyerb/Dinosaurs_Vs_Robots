using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulation/run example from video

            Robot robotOne = new Robot("Cylon", 40);
            robotOne.Attack();
            Battlefield battlefield = new Battlefield();
            battlefield.StartFight();

            Console.ReadLine();
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BLL;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            BoatController boatController = BoatController.Instance;

            Boat boat = new Boat();
            boat.brand = "Pepesito";
            boat.model = "Pepe Boat";
            boat.competitorCode = "45464645";
            boat.type = "Lancha";
            boat.numPassengers = 41;
            boat.costPerDay = 55;
            //boatController.Create(boat);
            //boatController.Delete(boat);

            Boat boatFind = boatController.Select(3);

            

            Console.ReadKey();
        }
    }
}

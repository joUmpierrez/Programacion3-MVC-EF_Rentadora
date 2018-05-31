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
            boat.brand = "sss";
            boat.competitorCode = "554f";
            boat.costPerDay = 55;
            boat.model = "aaa";
            boat.numPassengers = 44;
            boat.type = "sss";

            //boatController.Create(boat);

            foreach (Boat item in boatController.Read())
            {
                Console.WriteLine($"{item.id} ---> {item.brand} ---> {item.active}");
            }


            Console.ReadKey();
        }
    }
}

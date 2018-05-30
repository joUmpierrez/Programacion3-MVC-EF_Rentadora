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

<<<<<<< HEAD
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
=======
            Employee employee = new Employee();

            employee.name = "Joaquin";
            employee.lastname = "Umpierrez";
            employee.telephoneNum = "095084602";
            employee.employeeNum = 44575548;
            employee.password = "heimdall23911";

            db.employees.Add(employee);

            Client client = new Client();
            client.name = "Facundo";
            client.lastname = "Blanco";
            client.telephoneNum = "422668676";
            client.idCard = 45451;

            db.clients.Add(client);
            db.SaveChanges();

            
>>>>>>> 29ebff220d9df3822d08a9e9352ab9bea8dd6ae4
        }
    }
}

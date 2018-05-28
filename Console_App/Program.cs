﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalContext db = new RentalContext();

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

            
        }
    }
}

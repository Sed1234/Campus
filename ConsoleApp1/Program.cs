using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusLib.Model;
using CampusLib;
using CampusLibService;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User Admin = new User("Admin","Admin", "Admin","Admin@mail.ru");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Check  request");
            Console.WriteLine("3. Get All Students");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Student student = new Student();
                        Console.WriteLine("Input first name");
                        student.FName = Console.ReadLine();
                        Console.WriteLine("Input second name");
                        student.Sname = Console.ReadLine();
                        Console.WriteLine("Input Email");
                        student.EMail = Console.ReadLine();
                        Console.WriteLine("Input password");
                        student.Password = Console.ReadLine();
                         AdminModul admin = new AdminModul();
                         admin.CreateStudent(student, Status.Approved, Admin.Role, @"C:\Users\КимС\source\student.xml");
                        //AddToXML.CreateStudent(student, @"C:\Users\КимС\source\student.xml");


                    }
                    break;
                case 2:
                    {
                        //RequestToAdd request = new RequestToAdd();
                        //Console.WriteLine("Choose patient by ID");
                        //request.Patient.PatientId = Convert.ToInt32(Console.ReadLine());
                        //AddToDB.CreateRequest(request);

                    }
                    break;
                case 3:
                    {
                        //foreach (var request in AddToDB.ReturnAllRequests())
                        //{

                        //    Console.WriteLine($"{request.Patient.FName} {request.Patient.MName} {request.Organization.Name} {request.Status.ToString()}");
                        //}
                    }
                    break;
            }
        }

    }
    
}

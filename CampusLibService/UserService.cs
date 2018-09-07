using System;
using System.Collections.Generic;
using System.Text;
using CampusLib.Model;
using CampusLib;


namespace CampusLibService
{
	class UserService
	{
		public static void AddStudentAdmin(Student student , string path)
		{

            AddToXML check = new AddToXML();
            if (check.ReturnAllStudent(path)== false)
             AddToXML.CreateStudent(student, path); 
            else
             AddToXML.AddStudent(student, path);
		}
		public void AddUser(User user, string path)
		{
            AddToXML check = new AddToXML();
            if (check.ReturnAllUsers(path) == false)
                AddToXML.CreateUser(user, path);
            else
                AddToXML.AddUser(user, path);
        }
		public void AddCompany(Company company, string path)
		{
            AddToXML check = new AddToXML();
            if (check.ReturnAllUsers(path) == false)
                AddToXML.CreateCompany(company, path);
            else
                AddToXML.AddCompany(company, path);
        }
	}
}

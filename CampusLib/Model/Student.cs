using System;
using System.Collections.Generic;
using System.Text;

namespace CampusLib.Model
{
	public class Student:IUser
	{

		public Student() : this("", "", "", "") { }

		public Student(string fname, string sname, string password, string email)
		{
			FName = fname;
			Sname = sname;
			Password = password;
			EMail = email;
			resume = new Resume();
		}
		public int StudentId { get; set; }
		public string Password { get; set; }
		public string FName { get; set; }
		public string Sname { get; set; }
		public string MName { get; set; }
		public string EMail { get; set; }
		public DateTime DoB { get; set; }

		public Resume resume;

	}
}

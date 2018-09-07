using System;
using System.Collections.Generic;
using System.Text;

namespace CampusLib.Model
{
	public class Company
	{
		public Company() : this("", "", "") { }
		public Company(string name, string address, string phone)
		{
			Name = name;
			Address = address;
			Phone = phone;
			vacancies = new List<Vacansy>();
		}
		public int CompId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public List<Vacansy> vacancies;
	}
}

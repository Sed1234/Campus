using System;
using System.Collections.Generic;
using System.Text;

namespace CampusLib.Model
{
	public class Resume
	{

        public int ResumeId	{ get; set; }
		public string Education { get; set; }
		public string YearsOfEduction { get; set; }
		public string Speciality { get; set; }
		public string Experience { get; set; }
		public int DesiredSalary { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CampusLib.Model
{
	public interface IUser
	{
		string FName { get; set; }
		string Sname { get; set; }
		string MName { get; set; }
		string EMail { get; set; }
		DateTime DoB { get; set; }
	}
}

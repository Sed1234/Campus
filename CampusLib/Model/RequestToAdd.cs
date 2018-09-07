using System;
using System.Collections.Generic;
using System.Text;

namespace CampusLib.Model
{
	public enum Status
	{
		Create,
		Approved,
		Cancel
	}
	public class RequestToAdd
	{
		public int RequestToAddId { get; set; }
		public DateTime DateOfCreation { get; set; }
		public DateTime StatusDate { get; private set; }
		public Student Student { get; set; }
		public Company Company { get; set; }

		private Status Status_;
		public Status Status
		{
			get
			{
				return Status_;
			}
			set
			{
				if (value == Status.Approved || value == Status.Cancel)
					StatusDate = DateTime.Now;

				Status_ = value;
			}
		}

	}
}

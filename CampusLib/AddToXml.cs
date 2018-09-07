using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using CampusLib.Model;

namespace CampusLib
{
	[Serializable]
	public class AddToXML
	{
        public string  Path { get; set; }
        public static void SerializeRequest(RequestToAdd request , string Path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(RequestToAdd));
			using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, request);
			}
		}

		public bool   ReturnAllRequests(string path)
		{

            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(RequestToAdd));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<RequestToAdd> req = formatter.Deserialize(fs) as List<RequestToAdd>; //db.GetCollection<RequestToAdd>("RequestToAdd").FindAll();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

		public static void AddRequest(RequestToAdd request, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(RequestToAdd));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				var requests = formatter.Deserialize(fs) as List<RequestToAdd>;
				requests.Add(request);
				formatter.Serialize(fs, requests);
			}

		}

		public static void UpdateRequest(RequestToAdd request, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(RequestToAdd));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				List<RequestToAdd> requests = formatter.Deserialize(fs) as List<RequestToAdd>;
				foreach (RequestToAdd a in requests)
				{
					if (a.RequestToAddId == request.RequestToAddId)
					{
						a.Status = request.Status;
					}
				}
				formatter.Serialize(fs, requests);
			}

		}

		public static void CreateUser(User user, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(User));
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, user);
			}
		}

		public static void AddUser(User user , string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(User));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				var Users = formatter.Deserialize(fs) as List<User>;
				Users.Add(user);
				formatter.Serialize(fs, Users);
			}

		}

		public bool ReturnAllUsers(string path)
		{
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(User));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<User> users = formatter.Deserialize(fs) as List<User>; //db.GetCollection<RequestToAdd>("RequestToAdd").FindAll();
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
		}

		public static void UpdateUser(User user, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(User));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				List<User> Users = formatter.Deserialize(fs) as List<User>;
				foreach (User a in Users)
				{
					if (a.UserId == user.UserId)
					{
						a.EMail = user.EMail;
					}
				}
				formatter.Serialize(fs, Users);
			}

		}

		public static void CreateStudent(Student Student, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Student));
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, Student);
			}
		}

		public static void AddStudent(Student Student, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Student));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				var Students = formatter.Deserialize(fs) as List<Student>;
				Students.Add(Student);
				formatter.Serialize(fs, Students);
			}

		}

		public bool ReturnAllStudent(string path)
		{
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Student));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<Student> Students = formatter.Deserialize(fs) as List<Student>; //db.GetCollection<RequestToAdd>("RequestToAdd").FindAll();
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
		}

		public static void UpdateStudents(Student Student, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Student));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				List<Student> Students = formatter.Deserialize(fs) as List<Student>;
				foreach (Student a in Students)
				{
					if (a.StudentId == Student.StudentId)
					{
						a.resume.Experience = Student.resume.Experience;
						//Students.Add(a);
					}
				}
				formatter.Serialize(fs, Students);
			}

		}

		public static void CreateCompany(Company Company, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Company));
			using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, Company);
			}
		}

		public static void AddCompany(Company Company, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Company));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				var Companies = formatter.Deserialize(fs) as List<Company>;
				Companies.Add(Company);
				formatter.Serialize(fs, Companies);
			}

		}

		public bool ReturnAllCompany(string path)
		{
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Company));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<Company> Companies = formatter.Deserialize(fs) as List<Company>; //db.GetCollection<RequestToAdd>("RequestToAdd").FindAll();
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
		}

		public static void UpdateCompany(Company Company , Vacansy vacancy, string path)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Company));
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				List<Company> Companies = formatter.Deserialize(fs) as List<Company>;
				foreach (Company a in Companies)
				{
					if (a.Name == Company.Name )
					{
						a.Phone = Company.Phone;
						a.Address = Company.Address;
						List<Vacansy> NewVacancy = a.vacancies as List<Vacansy>;
						foreach (Vacansy b in NewVacancy)
						{
							if (b.NameOfVacancy == vacancy.NameOfVacancy)
							{
								b.NeededExp = vacancy.NeededExp;
								b.MaxSalary = vacancy.MaxSalary;
							}
						}
					}
				}
				formatter.Serialize(fs, Companies);
			}

		}

	}
}

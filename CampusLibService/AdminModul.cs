using System;
using System.Collections.Generic;
using System.Text;
using CampusLib;
using CampusLib.Model;

namespace CampusLibService
{
    public class AdminModul
    {
        public bool ChangeStatus(RequestToAdd request, Status status, Role role, string path)
        {
            request.Status = status;
            User user = new User();
            user.Role = role;
            try
            {
                if (status == Status.Approved && role == Role.Admin)
                {

                    //Patient p = Patients.FirstOrDefault(x => x.IIN == request.Patient.IIN);
                    //if (p != null)
                    // p.Organization = request.Organization;

                    AddToXML.UpdateStudents(request.Student, path);

                    //Organization o = Organizations.FirstOrDefault(x =>
                    //x.Name.Equals(request.Organization.Name));
                    //if (o != null)
                    // o.Patients.Add(request.Patient);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool  CreateStudent(Student student, Status status, Role role, string path)
        {
            User user = new User();
            user.Role = role;
            try
            {
                if (role == Role.Admin)
                {

                    //Patient p = Patients.FirstOrDefault(x => x.IIN == request.Patient.IIN);
                    //if (p != null)
                    // p.Organization = request.Organization;

                    UserService.AddStudentAdmin(student, path);

                    //Organization o = Organizations.FirstOrDefault(x =>
                    //x.Name.Equals(request.Organization.Name));
                    //if (o != null)
                    // o.Patients.Add(request.Patient);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

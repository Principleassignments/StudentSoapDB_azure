﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentSoapDB_azure
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        IList<Student> GetAllStudents();

        [OperationContract]
        Student GetStudentById(int id);

        [OperationContract]
        Student GetStudentByName(string name);

        [OperationContract]
        void AddStudent(int id, string name);

        [OperationContract]
        void DeleteStudentById(int Id);

        [OperationContract]
        void UpdateStudent(string id, string name);

    }


   
}

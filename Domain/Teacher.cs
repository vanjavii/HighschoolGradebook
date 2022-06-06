using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Teacher : IDomainObject
    {
        public int IdTeacher { get; set; }
        [Required, RegularExpression(@"[A-Z][a-z]*", ErrorMessage = "Please enter valid Firstname!")]
        public string FirstName { get; set; }
        [Required,RegularExpression(@"[A-Z][a-z]*",ErrorMessage ="Please enter valid Lastname!")]
        public string LastName { get; set; }
        [Required]
        [Range(typeof(DateTime), "1/1/1950","11/4/2022",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, RegularExpression(@"0[1-3][0-9]{8}",ErrorMessage ="Please enter a valid Phonenumber!")]
        public string PhoneNumber { get; set; }
        [Required][Range(1,3)]
        public int AcademicLevel { get; set; }
        //[Required]
        public Subject Subject { get; set; }
        
        public ClassGroupDatabase ClassGroup { get; set; }

        public string TableName => "Teacher";

        public string InsertValues => $"'{FirstName}','{LastName}','{BirthDate}','{Address}','{PhoneNumber}',{AcademicLevel},{Subject.IdSubject},{ClassGroup.IdClassGroup}";

        public IDomainObject ReadObjectNoJoin(SqlDataReader reader)
        {
            Teacher t = new Teacher();
            t.IdTeacher = (int)reader["IdTeacher"];
            t.FirstName = (string)reader["FirstName"];
            t.LastName = (string)reader["LastName"];
            t.BirthDate = (DateTime)reader["BirthDate"];
            t.Address = (string)reader["Address"];
            t.PhoneNumber = (string)reader["PhoneNumber"];
            t.AcademicLevel = (int)reader["AcademicLevel"];            
            return t;
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Teacher t = new Teacher();
            t.IdTeacher = (int)reader["IdTeacher"];
            t.FirstName = (string)reader["FirstName"];
            t.LastName = (string)reader["LastName"];
            t.BirthDate = (DateTime)reader["BirthDate"];
            t.Address = (string)reader["Address"];
            t.PhoneNumber = (string)reader["PhoneNumber"];
            t.AcademicLevel = (int)reader["AcademicLevel"];
            t.Subject = new Subject
            {
                IdSubject = (int)reader["IdSubject"],
                SubjectName = (string)reader["SubjectName"],
                Description = (string)reader["Description"]
            };
            //t.ClassGroup = new ClassGroupDatabase
            //{
            //    IdClassGroup = (int)reader["IdClassHomeroomTeacher"],
            //    //Name = (string)reader["ClassGroupName"],
            //    //Stream = (int)reader["Stream"]
            //};
            return t;
        }

        public IDomainObject ReadObjectRowNoJoin(SqlDataReader reader)
        {
            Teacher t = new Teacher();
            t.IdTeacher = (int)reader["IdTeacher"];
            t.FirstName = (string)reader["FirstName"];
            t.LastName = (string)reader["LastName"];
            t.BirthDate = (DateTime)reader["BirthDate"];
            t.Address = (string)reader["Address"];
            t.PhoneNumber = (string)reader["PhoneNumber"];
            t.AcademicLevel = (int)reader["AcademicLevel"];
            //t.Subject = new Subject
            //{
            //    IdSubject = (int)reader["IdSubject"],
            //    SubjectName = (string)reader["SubjectName"],
            //    Description = (string)reader["Description"]
            //};
            ////t.ClassGroup = new ClassGroupDatabase
            ////{
            ////    IdClassGroup = (int)reader["IdClassHomeroomTeacher"],
            ////    //Name = (string)reader["ClassGroupName"],
            ////    //Stream = (int)reader["Stream"]
            ////};
            return t;
        }

        //public Subject Subject { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
